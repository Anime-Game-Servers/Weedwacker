using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class NightCrowGadgetEntity : ScriptGadgetEntity
    {
        internal NightCrowGadgetEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            NightCrowGadgetInfo nightCrow = new();
            //nightCrow.ArgumentList.AddRange();

            info.Gadget.NightCrowGadgetInfo = nightCrow;

            return info;
        }
    }
}