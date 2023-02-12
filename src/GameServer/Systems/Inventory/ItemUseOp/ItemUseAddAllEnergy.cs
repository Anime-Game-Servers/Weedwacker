using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Systems.Inventory.ItemUseOp
{
    [ItemUse(Data.Enums.ItemUseOp.ITEM_USE_ADD_ALL_ENERGY)]
    internal class ItemUseAddAllEnergy : BaseItemUse
    {
        private readonly float Energy;

        public ItemUseAddAllEnergy(Player.Player user, uint itemId) : base(user, itemId)
        {
            if(!float.TryParse(ItemData.itemUse.Where(w => w.useOp == Data.Enums.ItemUseOp.ITEM_USE_ADD_ALL_ENERGY).First().useParam[0], out Energy))
            {
                Energy = 0;
            }
        }
        internal override async Task<bool> Use(uint count = 1)
        {
            switch (ItemData.useTarget)
            {
                case ItemUseTarget.ITEM_USE_TARGET_CUR_AVATAR:
                    await User.TeamManager.CurrentAvatarEntity.AddEnergyAsync(Energy * count, Shared.Network.Proto.PropChangeReason.EnergyBall);
                    break;
                case ItemUseTarget.ITEM_USE_TARGET_CUR_TEAM:
                    float offFieldRatio = 1f - User.TeamManager.ActiveTeam.Count / 10f;
                    foreach(var x in User.TeamManager.ActiveTeam)
                    {
                        if (x.Key == User.TeamManager.CurrentCharacterIndex || ItemData.materialType == MaterialType.MATERIAL_FOOD)
                        {
                            await x.Value.AddEnergyAsync(Energy * count, Shared.Network.Proto.PropChangeReason.EnergyBall);
                        }
                        else await x.Value.AddEnergyAsync(Energy * offFieldRatio * count, Shared.Network.Proto.PropChangeReason.EnergyBall);
                    }
                    break;
                default:
                    //TODO: handle other cases
                    return false;

            }
            return true;
        }
    }
}
