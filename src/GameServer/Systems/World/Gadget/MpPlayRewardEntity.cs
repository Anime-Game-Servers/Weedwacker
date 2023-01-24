using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class MpPlayRewardEntity : ScriptGadgetEntity // wtf is this supposed to be?
    {
        internal MpPlayRewardEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            MpPlayRewardInfo rewardInfo = new()
            {
                //Resin = default
            };
            //rewardInfo.QualifyUidList.AddRange();
            //rewardInfo.RemainUidList.AddRange();

            info.Gadget.MpPlayReward = rewardInfo;

            return info;
        }
    }
}