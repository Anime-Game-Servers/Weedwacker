using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class FishPoolEntity : ScriptGadgetEntity
    {
        internal FishPoolEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            FishPoolInfo poolInfo = new()
            {
                //PoolId =,
                //TodayFishNum =,
            };
            //poolInfo.FishAreaList.AddRange();

            info.Gadget.FishPoolInfo = poolInfo;

            return info;
        }
    }
}