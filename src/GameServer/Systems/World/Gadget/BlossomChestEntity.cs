using Weedwacker.GameServer.Systems.Script.Scene;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class BlossomChestEntity : ScriptGadgetEntity
    {
        internal BlossomChestEntity(Scene? scene, SceneGroup.Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            BlossomChestInfo blossom = new()
            {
                //BlossomRefreshType = default,
                //DeadTime = default,
                //RefreshId = default,
                //Resin = default,
            };
            //blossom.QualifyUidList.AddRange();
            //blossom.RemainUidList.AddRange();

            info.Gadget.BlossomChest = blossom;

            return info;
        }
    }
}
