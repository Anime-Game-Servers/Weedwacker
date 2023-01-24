using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class RogueLikeGadgetEntity : ScriptGadgetEntity
    {
        internal RogueLikeGadgetEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            RoguelikeGadgetInfo roguelike = new()
            {
                //CellConfigId =,
                //CellId =,
                //CellState =,
                //CellType =
            };

            info.Gadget.RoguelikeGadgetInfo = roguelike;

            return info;
        }
    }
}
