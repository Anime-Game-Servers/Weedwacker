using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class GeneralRewardEntity : ScriptGadgetEntity
    {
        internal GeneralRewardEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            GadgetGeneralRewardInfo rewardInfo = new()
            {
                //DeadTime = default,
                //ItemParam = default,
                //Resin = default,
            };
            //rewardInfo.QualifyUidList.AddRange();
            //rewardInfo.RemainUidList.AddRange();

            info.Gadget.GeneralReward = rewardInfo;

            return info;
        }
    }
}
