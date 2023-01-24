using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class StatueGadgetEntity : ScriptGadgetEntity
    {
        private HashSet<uint> OpenedStatueUids;
        internal StatueGadgetEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            StatueGadgetInfo statue = new();
            statue.OpenedStatueUidList.AddRange(OpenedStatueUids);
            info.Gadget.StatueGadget = statue;

            return info;
        }
    }
}
