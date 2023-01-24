using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class GadgetWorktopEntity : ScriptGadgetEntity
    {
        public HashSet<uint> WorktopOptions;
        private bool IsGuestCanOperate = false;

        internal GadgetWorktopEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            SceneEntityInfo info = base.ToProto();
            WorktopInfo worktop = new()
            {
                IsGuestCanOperate = IsGuestCanOperate,
            };
            worktop.OptionList.AddRange(WorktopOptions);
            info.Gadget.Worktop = worktop;
            return info;
        }
    }
}
