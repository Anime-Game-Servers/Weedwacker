namespace Weedwacker.GameServer.Systems.Inventory.ItemUseOp
{
    [ItemUse(Enums.ItemUseOp.ITEM_USE_ACCEPT_QUEST)]
    internal class ItemUseAcceptQuest : BaseItemUse
    {
        public ItemUseAcceptQuest(Player.Player user, uint itemId) : base(user, itemId)
        {
        }

        internal override async Task<bool> Use(uint count = 1)
        {
            throw new NotImplementedException();
        }
    }
}
