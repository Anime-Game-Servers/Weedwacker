using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class DeshretObeliskGadgetEntity : ScriptGadgetEntity
    {
        internal DeshretObeliskGadgetEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            DeshretObeliskGadgetInfo deshretObelisk = new();
            //deshretObelisk.ArgumentList.AddRange();

            info.Gadget.DeshretObeliskGadgetInfo = deshretObelisk;

            return info;
        }
    }
}