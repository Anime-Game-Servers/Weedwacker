using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class CoinCollectOperatorEntity : ScriptGadgetEntity
    {
        internal CoinCollectOperatorEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            CoinCollectOperatorInfo operatorInfo = new()
            {
                //LevelId =
            };

            info.Gadget.CoinCollectOperatorInfo = operatorInfo;

            return info;
        }
    }
}