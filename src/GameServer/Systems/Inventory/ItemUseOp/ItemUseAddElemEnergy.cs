using KcpSharp;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory.ItemUseOp
{
    [ItemUse(Enums.ItemUseOp.ITEM_USE_ADD_ELEM_ENERGY)]
    internal class ItemUseAddElemEnergy : BaseItemUse
    {
        private readonly float energy = 0;
        private readonly Enums.ElementType element = Enums.ElementType.None;
        private readonly float altEnergy = 0;
        public ItemUseAddElemEnergy(Player.Player user, uint itemId) : base(user, itemId)
        {
            if(int.TryParse(ItemData.itemUse.Where(w => w.useOp == Enums.ItemUseOp.ITEM_USE_ADD_ELEM_ENERGY).First().useParam[0], out int elementID))
            {
                element = (Enums.ElementType)elementID;
            }
            float.TryParse(ItemData.itemUse.Where(w => w.useOp == Enums.ItemUseOp.ITEM_USE_ADD_ELEM_ENERGY).First().useParam[1], out energy);
            float.TryParse(ItemData.itemUse.Where(w => w.useOp == Enums.ItemUseOp.ITEM_USE_ADD_ELEM_ENERGY).First().useParam[2], out altEnergy);
        }
        internal override async Task<bool> Use(uint count = 1)
        {
            switch (ItemData.useTarget)
            {
                case ItemUseTarget.ITEM_USE_TARGET_CUR_AVATAR:
                    float energyAmount = User.TeamManager.CurrentAvatarEntity.Avatar.CurSkillDepot.Element?.Type == element ? energy : altEnergy;
                    await User.TeamManager.CurrentAvatarEntity.AddEnergyAsync(energyAmount * count, Shared.Network.Proto.PropChangeReason.EnergyBall);
                    break;
                case ItemUseTarget.ITEM_USE_TARGET_CUR_TEAM:
                    float offFieldRatio = 1f - User.TeamManager.ActiveTeam.Count / 10f;
                    foreach(var avatar in User.TeamManager.ActiveTeam)
                    {
                        if (avatar.Value.Avatar.CurSkillDepot.Element is null)
                            continue;
                        float amount = avatar.Value.Avatar.CurSkillDepot.Element.Type == element ? energy : altEnergy;
                        if (avatar.Key == User.TeamManager.CurrentCharacterIndex || ItemData.materialType == MaterialType.MATERIAL_FOOD) //The food items do not care for off field chars
                        {
                            await avatar.Value.AddEnergyAsync(amount * count, Shared.Network.Proto.PropChangeReason.EnergyBall);
                        }
                        else await avatar.Value.AddEnergyAsync(amount * offFieldRatio * count, Shared.Network.Proto.PropChangeReason.EnergyBall);
                    }
                    break;
                default:
                    //TODO: handle other cases if any?
                    return false;

            }
            return true;
        }
    }
}
