using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class VehicleEntity : ScriptGadgetEntity
    {
        internal VehicleEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            VehicleInfo vehicle = new()
            {
                //CurStamina =,
                //OwnerUid =,
            };
            //vehicle.MemberList.AddRange();

            info.Gadget.VehicleInfo = vehicle;

            return info;
        }
    }
}