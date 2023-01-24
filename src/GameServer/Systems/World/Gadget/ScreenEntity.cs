using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class ScreenEntity : ScriptGadgetEntity
    {
        internal ScreenEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            ScreenInfo screen = new()
            {
                //LiveId =,
                //ProjectorEntityId =,
            };

            info.Gadget.ScreenInfo = screen;

            return info;
        }
    }
}
