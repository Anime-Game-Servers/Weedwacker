
namespace Weedwacker.GameServer.Systems.Inventory.ItemUseOp
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ItemUseAttribute : Attribute
    {
        /* Enum of the operation */
        public readonly Data.Enums.ItemUseOp Op;

        public ItemUseAttribute(Data.Enums.ItemUseOp op)
        {
            Op = op;
        }
    }
}
