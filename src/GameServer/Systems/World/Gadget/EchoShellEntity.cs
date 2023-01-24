using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class EchoShellEntity : ScriptGadgetEntity
    {
        internal EchoShellEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            EchoShellInfo shellInfo = new()
            {
                //ShellId =
            };

            info.Gadget.ShellInfo = shellInfo;

            return info;
        }
    }
}
