using System.Numerics;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.World
{
    internal class ItemEntity : BaseGadgetEntity
    {
        public ItemConfig ItemData => Item.ItemData;
        public readonly uint Count;
        public readonly ulong Guid;
        private readonly GameItem Item; // DO NOT use to store in the inventory, just to have easy access to GameItem::ToProto

        public readonly bool Share;


        public static async Task<ItemEntity?> CreateAsync(Scene scene, Player.Player? player, ItemConfig itemData, Vector3 pos, uint count, bool share = true)
        {
            ulong guid = player == null ? scene.World.Host.GetNextGameGuid() : player.GetNextGameGuid();
            uint gadgetId;
            GameItem item;
            // Maybe subclass weapons and relics as materials?
            if (itemData is MaterialData material)
            {
                gadgetId = material.gadgetId;
                item = new MaterialItem(guid, itemData.id, count);
            }
            else if (itemData is WeaponData weapon)
            {
                gadgetId = weapon.gadgetId;
                item = new WeaponItem(guid, itemData.id, 0);
            }
            else if (itemData is ReliquaryData relic)
            {
                gadgetId = relic.gadgetId;
                item = new ReliquaryItem(guid, itemData.id, 0);
            }
            else
            {
                Logger.WriteErrorLine("invalid/unhandled drop item: " + itemData.id);
                return null;
            }
            ItemEntity itemEntity = new(scene, pos, count, share, guid, gadgetId, item);
            return itemEntity;
        }
        // In official game, some drop items are shared to all players, and some other items are independent to all players
        // For example, if you killed a monster in MP mode, all players could get drops but rarity and number of them are different
        // but if you broke regional mine, when someone picked up the drop then it disappeared
        private ItemEntity(Scene scene, Vector3 pos, uint count, bool share, ulong guid, uint gadgetId, GameItem item) : base(scene, gadgetId)
        {
            EntityId = Scene.World.GetNextEntityId(EntityIdType.GADGET);
            Position = pos;
            Guid = guid;
            Item = item;
            Count = count;
            Share = share;
        }

        internal override async Task OnInteractAsync(Player.Player player, GadgetInteractReq interactReq)
        {
            // check drop owner to avoid someone picked up item in others' world
            if (!Share)
            {
                int dropOwner = (int)(Guid >> 32);
                if (dropOwner != player.GameUid)
                {
                    return;
                }
            }

            await Scene.RemoveEntityAsync(this);

            // Add to inventory
            await player.Inventory.AddItemByIdAsync(ItemData.id, Count, ActionReason.SubfieldDrop);
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            info.Gadget.BornType = GadgetBornType.InAir;
            info.Gadget.TrifleItem = Item.ToProto();

            return info;
        }
    }
}
