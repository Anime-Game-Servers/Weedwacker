﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using static Weedwacker.GameServer.Data.Excel.WeaponData;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class Avatar
    {
        [BsonElement] public int BornTime { get; private set; }
        [BsonElement] public int AvatarId { get; private set; }           // Id of avatar
        [BsonIgnore] private Player.Player Owner { get; set; } // Loaded by DatabaseManager
        [BsonIgnore] public AvatarCompiledData Data => GameServer.AvatarInfo[AvatarId];
        [BsonIgnore] public ulong Guid { get; private set; }           // Player unique Avatar id. Generated each session
        [BsonIgnore] public int EntityId { get; private set; }

        [BsonElement] public int Level { get; private set; } = 1;
        public int Exp;
        [BsonElement] public int PromoteLevel { get; private set; } = 0;
        public int Satiation; // ?
        public int SatiationPenalty; // ?
        [BsonElement] public LifeState LifeState { get; private set; } = LifeState.LIFE_ALIVE;
        public HashSet<string> EquipOpenConfigs; // openConfigs from relics and weapon TODO
        [BsonElement] public int CurrentDepotId { get; private set; }
        [BsonSerializer(typeof(IntDictionarySerializer<SkillDepot>))]
        [BsonElement] public Dictionary<int, SkillDepot> SkillDepots { get; private set; } = new();
        
        [BsonElement] public FetterSystem Fetters { get; private set; }
        [BsonIgnore] public Dictionary<EquipType, EquipItem> Equips { get; private set; } = new(); // Loaded through the inventory system
        [BsonElement] public Dictionary<FightProperty, float> FightProp { get; private set; } = new();
        [BsonElement] public HashSet<string> AppliedOpenConfigs { get; private set; } = new();

        [BsonElement] public int FlyCloak { get; private set; } = 140001;
        [BsonElement] public int Costume { get; private set; } = default; // no costume

        public static Task<Avatar> CreateAsync(int avatarId, Player.Player owner)
        {
            var ret = new Avatar();
            return ret.InitializeAsync(avatarId, owner);
        }
        private async Task<Avatar> InitializeAsync(int avatarId, Player.Player owner)
        {
            AvatarId = avatarId;

            if (Data.GeneralData.candSkillDepotIds.Length > 0)
            {
                foreach (int depotId in Data.GeneralData.candSkillDepotIds)
                {
                    SkillDepots.Add(depotId, new SkillDepot(this, depotId, owner));
                }
            }
            else
            {
                SkillDepots.Add(Data.GeneralData.skillDepotId, new SkillDepot(this, Data.GeneralData.skillDepotId, owner));
            }
            CurrentDepotId = Data.GeneralData.skillDepotId;
            Fetters = await FetterSystem.CreateAsync(this, owner);
            Owner = owner;
            BornTime = (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000);

            // Combat properties
            foreach (FightProperty property in (FightProperty[])Enum.GetValues(typeof(FightProperty)))
            {
                if ((int)property > 0 && (int)property < 3000) FightProp.Add(property, 0f);
            }

            // Set stats
            await RecalcStatsAsync();
            await SetCurrentHp(FightProp[FightProperty.FIGHT_PROP_MAX_HP]);

            var weapon = Owner.Inventory.AddItemByIdAsync(Data.GeneralData.initialWeapon).Result;
            await EquipWeapon((WeaponItem)weapon, false);

            return this;
        }

        public Player.Player GetOwner() { return Owner; }

        internal Avatar Clone()
        {
            throw new NotImplementedException();
        }

        public async Task OnLoadAsync(Player.Player owner)
        {
            Owner = owner;
            Guid = owner.GetNextGameGuid();
            var tasks = new List<Task>
            {
                Fetters.OnLoadAsync(owner, this)
            };
            foreach (SkillDepot depot in SkillDepots.Values)
            {
                tasks.Add(depot.OnLoadAsync(owner, this));
            }
            await Task.WhenAll(tasks);
        }
        public async Task<bool> SetCurrentHp(float value, bool notifyClient = true)
        {
            if (FightProp[FightProperty.FIGHT_PROP_MAX_HP] <= value) return false;
            FightProp[FightProperty.FIGHT_PROP_CUR_HP] = value;
            // Update
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{nameof(FightProp)}.{FightProperty.FIGHT_PROP_CUR_HP}", value);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);
            if(notifyClient) await Owner.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(this, FightProperty.FIGHT_PROP_CUR_HP));
            return true;
        }
        public SkillDepot GetCurSkillDepot()
        {
            return SkillDepots[CurrentDepotId];
        }
        public async Task<bool> SetFlyCloakAsync(int cloakId)
        { 
            FlyCloak = cloakId;
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{FlyCloak}", FlyCloak);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);
            await Owner.SendPacketAsync(new PacketAvatarFlycloakChangeNotify(this));

            return true;
        }

        static public int GetMinPromoteLevel(int level)
        {
            if (level > 80)
            {
                return 6;
            }
            else if (level > 70)
            {
                return 5;
            }
            else if (level > 60)
            {
                return 4;
            }
            else if (level > 50)
            {
                return 3;
            }
            else if (level > 40)
            {
                return 2;
            }
            else if (level > 20)
            {
                return 1;
            }
            return 0;
        }

        public WeaponItem? GetWeapon()
        {
            return (WeaponItem?)Equips.GetValueOrDefault(EquipType.EQUIP_WEAPON);
        }

        public GameItem? GetRelic(EquipType slot)
        {
            if(slot == EquipType.EQUIP_WEAPON)
            {
                Logger.WriteErrorLine("Tried to access weapon as relic");
                return null;
            }
            return Equips[slot];
        }

        public float GetCurrentEnergy()
        {
            if (GetCurSkillDepot().Element != null)
                return GetCurSkillDepot().Element.CurEnergy;
            else
                return 0;
        }
        public async Task<bool> SetCurrentEnergy(float currentEnergy, bool update = true)
        {
            if (GetCurSkillDepot().Element != null)
            {
                GetCurSkillDepot().Element.CurEnergy = currentEnergy;
                FightProp[GetCurSkillDepot().Element.CurEnergyProp] = currentEnergy;

                // false = used in RecalcStatsAsync or is in Tower team
                if (update)
                {
                    // Update
                    var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var updateQuery = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{GetCurSkillDepot().Element.CurEnergyProp}", currentEnergy);
                    await DatabaseManager.UpdateAvatarsAsync(filter, updateQuery);

                    await Owner.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(this, GetCurSkillDepot().Element.CurEnergyProp));
                }
                return true;
            }
            else
                return false;
        }

        public async Task<bool> AddToFightProperty(FightProperty prop, float value, bool update = true)
        {
            FightProp[prop] += value;

            // false = used in RecalcStatsAsync
            if (update)
            {
                // Update
                var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var updateQuery = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{nameof(FightProp)}.{prop}", FlyCloak);
                await DatabaseManager.UpdateAvatarsAsync(filter, updateQuery);
                await Owner.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(this, prop));
                return true;
            }
            return true;
        }

        public async Task<bool> EquipRelic(ReliquaryItem item, bool notifyClient = true)
        {
            // Sanity check equip type
            EquipType itemEquipType = item.ItemData.equipType;
            if (itemEquipType == EquipType.EQUIP_NONE)
            {
                return false;
            }
 
            else if (GetRelic(itemEquipType) != null)
            {
                // Unequip item in current slot if it exists
                await UnequipRelic(itemEquipType);
            }

            // Set equip
            Equips[itemEquipType] = item;
            item.EquippedAvatar = AvatarId;

            //TODO add relic openConfigs

            // Update Database
            var inventoryFilter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var inventoryUpdate = Builders<InventoryManager>.Update.Set($"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_RELIQUARY}.{nameof(RelicTab.Items)}.{item.Id}.{nameof(EquipItem.EquippedAvatar)}", item.EquippedAvatar);
            await DatabaseManager.UpdateInventoryAsync(inventoryFilter, inventoryUpdate);

            if (Owner.HasSentLoginPackets)
            {
                await Owner.SendPacketAsync(new PacketAvatarEquipChangeNotify(this, item, itemEquipType));
            }

           await RecalcStatsAsync(notifyClient);

            return true;
        }
        public async Task<bool> EquipWeapon(WeaponItem item, bool notifyClient = true)
        {
            if (GetWeapon() != null)
            {
                // Unequip item in current slot if it exists
                await UnequipWeapon(notifyClient);
            }

            // Set equip
            Equips[EquipType.EQUIP_WEAPON] = item;
            item.EquippedAvatar = AvatarId;
            if(Owner.World != null)
                item.WeaponEntityId = Owner.World.GetNextEntityId(EntityIdType.WEAPON);

            //TODO apply weapon openConfigs

            // Update Database
            var inventoryFilter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var inventoryUpdate = Builders<InventoryManager>.Update.Set($"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_WEAPON}.{nameof(WeaponTab.Items)}.{item.Id}.{nameof(WeaponItem.EquippedAvatar)}", item.EquippedAvatar);
            await DatabaseManager.UpdateInventoryAsync(inventoryFilter, inventoryUpdate);

            if (Owner.HasSentLoginPackets && notifyClient)
            {
                await Owner.SendPacketAsync(new PacketAvatarEquipChangeNotify(this, item, EquipType.EQUIP_WEAPON));
            }

            await RecalcStatsAsync(notifyClient);

            return true;                         
        }

        public async Task<bool> UnequipRelic(EquipType slot, bool notifyClient = true)
        {
            ReliquaryItem item = (ReliquaryItem)Equips[slot];
            Equips.Remove(slot);

            //TODO remove relic openConfigs


            if (item != null)
            {
                item.EquippedAvatar = 0;

                // Update Database
                var inventoryFilter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var inventoryUpdate = Builders<InventoryManager>.Update.Set($"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_RELIQUARY}.{nameof(RelicTab.Items)}.{item.Id}.{nameof(ReliquaryItem.EquippedAvatar)}", item.EquippedAvatar);
                await DatabaseManager.UpdateInventoryAsync(inventoryFilter, inventoryUpdate);

                await Owner.SendPacketAsync(new PacketAvatarEquipChangeNotify(this, slot));
                await RecalcStatsAsync(notifyClient);
                return true;
            }

            return false;
        }
        public async Task<bool> UnequipWeapon(bool notifyClient = true)
        {
            WeaponItem item = (WeaponItem)Equips[EquipType.EQUIP_WEAPON];
            Equips.Remove(EquipType.EQUIP_WEAPON);

            //TODO remove weapon openConfigs

            if (item != null)
            {
                item.EquippedAvatar = 0;

                // Update Database
                var inventoryFilter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var inventoryUpdate = Builders<InventoryManager>.Update.Set($"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_WEAPON}.{nameof(WeaponTab.Items)}.{item.Id}.{nameof(WeaponItem.EquippedAvatar)}", item.EquippedAvatar);
                await DatabaseManager.UpdateInventoryAsync(inventoryFilter, inventoryUpdate);

                if (notifyClient) await Owner.SendPacketAsync(new PacketAvatarEquipChangeNotify(this, EquipType.EQUIP_WEAPON));
                await RecalcStatsAsync(notifyClient);              
                return true;
            }

            return false;
        }

        public async Task RecalcStatsAsync(bool forceSendAbilityChange = false)
        {
            // Setup
            AvatarPromoteData promoteData = Data.PromoteData[PromoteLevel];

            // Get hp percent, set to 100% if none
            float hpPercent = FightProp[FightProperty.FIGHT_PROP_MAX_HP] == 0 ? 1f : FightProp[FightProperty.FIGHT_PROP_CUR_HP] / FightProp[FightProperty.FIGHT_PROP_MAX_HP];

            // Store current energy value for later
            float currentEnergy = GetCurrentEnergy();

            // Clear properties
            foreach (FightProperty prop in FightProp.Keys)
            {
                FightProp[prop] = 0f;
            }

            // Base stats
            FightProp[FightProperty.FIGHT_PROP_BASE_HP] = Data.GetBaseHp(Level);
            FightProp[FightProperty.FIGHT_PROP_BASE_ATTACK] = Data.GetBaseAttack(Level);
            FightProp[FightProperty.FIGHT_PROP_BASE_DEFENSE] = Data.GetBaseDefense(Level);
            FightProp[FightProperty.FIGHT_PROP_CRITICAL] = Data.GetBaseCritical();
            FightProp[FightProperty.FIGHT_PROP_CRITICAL_HURT] = Data.GetBaseCriticalHurt();
            FightProp[FightProperty.FIGHT_PROP_CHARGE_EFFICIENCY] = 1f;


            foreach (FightPropData fightPropData in promoteData.addProps)
            {
                FightProp[fightPropData.propType] += fightPropData.value;
            }

            // Set energy usage
            await SetCurrentEnergy(currentEnergy, false);

            // Artifacts

            // artifact set ids and number of artifacts
            Dictionary<int, int> sets = new();

            for (int slotId = 1; slotId <= 5; slotId++)
            {
                // Get artifact
                
                if (!Equips.TryGetValue((EquipType)slotId, out EquipItem equip))
                {
                    continue;
                }
                // Artifact main stat
                ReliquaryMainPropData mainPropData = GameData.ReliquaryMainPropDataMap[(equip as ReliquaryItem).MainPropId];
                if (mainPropData != null)
                {
                    ReliquaryLevelData levelData = GameData.ReliquaryLevelDataMap[Tuple.Create(equip.ItemData.rankLevel, equip.Level)];
                    if (levelData != null)
                    {
                        FightProp[mainPropData.propType] += levelData.addProps.Where(w => w.propType == mainPropData.propType).First().value;
                    }
                }
                // Artifact sub stats
                if ((equip as ReliquaryItem).AppendPropIdList != null)
                {
                    foreach (int appendPropId in (equip as ReliquaryItem).AppendPropIdList)
                    {
                        ReliquaryAffixData affixData = GameData.ReliquaryAffixDataMap[appendPropId];
                        if (affixData != null)
                        {
                            FightProp[affixData.propType] += affixData.propValue;
                        }
                    }
                }
                // Set bonus
                if ((equip as ReliquaryItem).ItemData.setId > 0)
                {
                    sets[(equip as ReliquaryItem).ItemData.setId] += 1;
                }
            }

            // Artifact Set stuff
            foreach (KeyValuePair<int,int> e in sets.ToList())
            {
                ReliquarySetData setData = GameData.ReliquarySetDataMap[e.Key];
                if (setData == null)
                {
                    continue;
                }

                // Calculate how many items are from the set
                int amount = e.Value;

                // Add affix data from set bonus
                for (int setIndex = 0; setIndex < setData.setNeedNum.Length; setIndex++)
                {
                    if (amount >= setData.setNeedNum[setIndex])
                    {
                        int affixId = (setData.EquipAffixId * 10) + setIndex;

                        EquipAffixData affix = GameData.EquipAffixDataMap[affixId];
                        if (affix == null)
                        {
                            continue;
                        }

                        // Add properties from this affix to our avatar
                        foreach (FightPropData prop in affix.addProps)
                        {
                            if (prop.propType == FightProperty.FIGHT_PROP_NONE) continue;
                            FightProp[prop.propType] += prop.value;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // Weapon
            WeaponItem weapon = GetWeapon();
            if (weapon != null)
            {
                // Add stats
                WeaponCurveData curveData = GameData.WeaponCurveDataMap[weapon.Level];
                if (curveData != null)
                {
                    if (weapon.ItemData.weaponProp != null)
                    {
                        foreach (WeaponProperty weaponProperty in weapon.ItemData.weaponProp)
                        {
                            if (weaponProperty.propType == FightProperty.FIGHT_PROP_NONE) continue;
                            FightProp[weaponProperty.propType] += WeaponCurveData.CalcValue(weaponProperty.initValue, curveData.GetArith(weaponProperty.type));
                        }
                    }
                }
                // Weapon promotion stats
                WeaponPromoteData wepPromoteData = GameData.WeaponPromoteDataMap[Tuple.Create(weapon.ItemData.weaponPromoteId, weapon.PromoteLevel)];
                if (wepPromoteData != null)
                {
                    foreach (FightPropData prop in wepPromoteData.addProps)
                    {
                        if (prop.value == 0f || prop.propType == FightProperty.FIGHT_PROP_NONE)
                        {
                            continue;
                        }
                        FightProp[prop.propType] += prop.value;
                    }
                }
                // Add weapon skill from affixes
                if (weapon.Affixes != null && weapon.Affixes.Count > 0)
                {
                    // Weapons usually dont have more than one affix but just in case...
                    foreach (int af in weapon.Affixes)
                    {
                        if (af == 0)
                        {
                            continue;
                        }
                        // Calculate affix id
                        int affixId = (af * 10) + weapon.Refinement;
                        EquipAffixData affix = GameData.EquipAffixDataMap[affixId];
                        if (affix == null)
                        {
                            continue;
                        }

                        // Add properties from this affix to our avatar
                        foreach (FightPropData prop in affix.addProps)
                        {
                            FightProp[prop.propType] += prop.value;
                        }
                    }
                }
            }

            // Proud skills
            foreach (ProudSkillData proudSkill in GetCurSkillDepot().InherentProudSkillOpens)
            {
                // Add properties from this proud skill to our avatar
                foreach (FightPropData prop in proudSkill.addProps)
                {
                    FightProp[prop.propType] += prop.value;
                }
            }

            // Set % stats
            FightProp[FightProperty.FIGHT_PROP_MAX_HP] =
                (FightProp[FightProperty.FIGHT_PROP_BASE_HP] * (1f + FightProp[FightProperty.FIGHT_PROP_HP_PERCENT])) + FightProp[FightProperty.FIGHT_PROP_HP];
            FightProp[FightProperty.FIGHT_PROP_CUR_ATTACK] =
                FightProp[FightProperty.FIGHT_PROP_BASE_ATTACK] * (1f + FightProp[FightProperty.FIGHT_PROP_ATTACK_PERCENT]) + FightProp[FightProperty.FIGHT_PROP_ATTACK];
            FightProp[FightProperty.FIGHT_PROP_CUR_DEFENSE] =
                FightProp[FightProperty.FIGHT_PROP_BASE_DEFENSE] * (1f + FightProp[FightProperty.FIGHT_PROP_DEFENSE_PERCENT]) + FightProp[FightProperty.FIGHT_PROP_DEFENSE];

            // Set current hp
            FightProp[FightProperty.FIGHT_PROP_CUR_HP] = FightProp[FightProperty.FIGHT_PROP_MAX_HP] * hpPercent;

            // Update Database
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var updateQuery = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{nameof(FightProp)}", FightProp);
            await DatabaseManager.UpdateAvatarsAsync(filter, updateQuery);

            // Packet
            if (Owner.HasSentLoginPackets)
            {
                // Update stats for client
                await Owner.SendPacketAsync(new PacketAvatarFightPropNotify(this));
            }
        }

        public AvatarInfo ToProto()
        {
            int fetterLevel = Fetters.FetterLevel;
            AvatarFetterInfo avatarFetter = new AvatarFetterInfo() { ExpLevel = (uint)fetterLevel };

            if (fetterLevel != 10)
            {
                avatarFetter.ExpNumber = (uint)Fetters.FetterExp;
            }
            else
            {
                avatarFetter.RewardedFetterLevelList.Add(10);
            }
            foreach (FetterData fetter in Fetters.FetterStates.Values)
            {
                avatarFetter.FetterList.Add(fetter);
            }

            AvatarInfo avatarInfo = new()
            {
                AvatarId = (uint)AvatarId,
                Guid = (uint)Guid,
                CostumeId = (uint)Costume,
                WearingFlycloakId = (uint)FlyCloak,
                FetterInfo = avatarFetter,
                BornTime = (uint)BornTime,
                SkillDepotId = (uint)CurrentDepotId,
                LifeState = (uint)LifeState,
                AvatarType = 1,
                CoreProudSkillLevel = GetCurSkillDepot().GetCoreProudSkillLevel()
            };

            foreach (ProudSkillData proud in GetCurSkillDepot().InherentProudSkillOpens)
            {
                avatarInfo.InherentProudSkillList.Add((uint)proud.proudSkillId);
            }
            foreach (AvatarTalentData talent in GetCurSkillDepot().Talents)
            {
                avatarInfo.TalentIdList.Add((uint)talent.talentId);
            }
            foreach (int skill in GetCurSkillDepot().GetSkillLevelMap().Keys)
            {
                avatarInfo.SkillLevelMap.Add((uint)skill, (uint)GetCurSkillDepot().GetSkillLevelMap()[skill]);
            }
            foreach (FightProperty prop in FightProp.Keys)
            {
                avatarInfo.FightPropMap.Add((uint)prop, FightProp[prop]);
            }
            foreach (int groupId in GetCurSkillDepot().ProudSkillExtraLevelMap.Keys)
            {
                avatarInfo.ProudSkillExtraLevelMap.Add((uint)groupId, (uint)GetCurSkillDepot().ProudSkillExtraLevelMap[groupId]);
            }
            foreach (int skillId in GetCurSkillDepot().SkillExtraChargeMap.Keys)
            {
                avatarInfo.SkillMap.Add((uint)skillId, new AvatarSkillInfo() { MaxChargeCount = (uint)GetCurSkillDepot().SkillExtraChargeMap[skillId] });
            }

            foreach (GameItem item in Equips.Values)
            {
                avatarInfo.EquipGuidList.Add(item.Guid);
            }

            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_LEVEL, Ival = Level, Val = Level });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_EXP, new PropValue() { Type = (uint)PlayerProperty.PROP_EXP, Ival = (uint)Exp, Val = (uint)Exp });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_BREAK_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_BREAK_LEVEL, Ival = (uint)PromoteLevel, Val = (uint)PromoteLevel });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_VAL, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_VAL, Ival = 0, Val = 0 });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, Ival=0, Val = 0 });

            return avatarInfo;
        }

        // used only in character showcase
        public ShowAvatarInfo ToShowAvatarInfoProto()
        {
            int fetterLevel = Fetters.FetterLevel;
            AvatarFetterInfo avatarFetter = new() { ExpLevel = (uint)fetterLevel };

            ShowAvatarInfo showAvatarInfo = new()
            {
                AvatarId = (uint)AvatarId,
                CostumeId = (uint)Costume,
                SkillDepotId = (uint)CurrentDepotId,
                CoreProudSkillLevel = GetCurSkillDepot().GetCoreProudSkillLevel(),
                FetterInfo = avatarFetter
            };
            foreach (AvatarTalentData talent in GetCurSkillDepot().Talents)
            {
                showAvatarInfo.TalentIdList.Add((uint)talent.talentId);
            }
            foreach (ProudSkillData proudSkill in GetCurSkillDepot().InherentProudSkillOpens)
            {
                showAvatarInfo.InherentProudSkillList.Add((uint)proudSkill.proudSkillId);
            }
            foreach (int skill in GetCurSkillDepot().GetSkillLevelMap().Keys)
            {
                showAvatarInfo.SkillLevelMap.Add((uint)skill, (uint)GetCurSkillDepot().GetSkillLevelMap()[skill]);
            }
            foreach (int groupId in GetCurSkillDepot().ProudSkillExtraLevelMap.Keys)
            {
                showAvatarInfo.ProudSkillExtraLevelMap.Add((uint)groupId, (uint)GetCurSkillDepot().ProudSkillExtraLevelMap[groupId]);
            }
            foreach (FightProperty prop in FightProp.Keys)
            {
                showAvatarInfo.FightPropMap.Add((uint)prop, FightProp[prop]);
            }


            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_LEVEL, Ival = (uint)Level, Val = (uint)Level });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_EXP, new PropValue() { Type = (uint)PlayerProperty.PROP_EXP, Ival = (uint)Exp, Val = (uint)Exp });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_BREAK_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_BREAK_LEVEL, Ival = (uint)PromoteLevel, Val = (uint)PromoteLevel });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_VAL, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_VAL, Ival = (uint)Satiation, Val = (uint)Satiation });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_VAL, Ival = (uint)SatiationPenalty, Val = (uint)SatiationPenalty });
            int maxStamina = Owner.PlayerProperties[PlayerProperty.PROP_MAX_STAMINA];
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_MAX_STAMINA, new PropValue() { Type = (uint)PlayerProperty.PROP_MAX_STAMINA, Ival = (uint)maxStamina, Val = (uint)maxStamina });

            foreach (ReliquaryItem item in Equips.Values)
            {
                showAvatarInfo.EquipList.Add(new ShowEquip()
                {
                    ItemId = (uint)item.ItemId,
                    Reliquary = item.ToReliquaryProto()
                });
            }

            WeaponItem weapon = (WeaponItem)Equips[EquipType.EQUIP_WEAPON];
            showAvatarInfo.EquipList.Add(new ShowEquip()
            {
                ItemId = (uint)weapon.ItemId,
                Weapon = weapon.ToWeaponProto()
            });

            return showAvatarInfo;
        }
    }
}
