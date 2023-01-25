using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Systems.Inventory.ItemUseOp
{
    [ItemUse(Enums.ItemUseOp.ITEM_USE_ADD_ALL_ENERGY)]
    internal class ItemUseAddAllEnergy : BaseItemUse
    {
        private readonly float energy;

        public ItemUseAddAllEnergy(Player.Player user, uint itemId) : base(user, itemId)
        {
            if(!float.TryParse(ItemData.itemUse.Where(w => w.useOp == Enums.ItemUseOp.ITEM_USE_ADD_ALL_ENERGY).First().useParam[0], out energy))
            {
                energy = 0;
            }
        }
        internal override async Task<bool> Use(uint count = 1)
        {
            switch (ItemData.useTarget)
            {
                case ItemUseTarget.ITEM_USE_TARGET_CUR_AVATAR:
                    await User.TeamManager.CurrentAvatarEntity.AddEnergyAsync(energy * count, Shared.Network.Proto.PropChangeReason.EnergyBall);
                    break;
                case ItemUseTarget.ITEM_USE_TARGET_CUR_TEAM:
                    float offFieldRatio = 1f - User.TeamManager.ActiveTeam.Count / 10f;
                    foreach(var x in User.TeamManager.ActiveTeam)
                    {
                        if (x.Key == User.TeamManager.CurrentCharacterIndex || ItemData.materialType == MaterialType.MATERIAL_FOOD)
                        {
                            await x.Value.AddEnergyAsync(energy * count, Shared.Network.Proto.PropChangeReason.EnergyBall);
                        }
                        else await x.Value.AddEnergyAsync(energy * offFieldRatio * count, Shared.Network.Proto.PropChangeReason.EnergyBall);
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
