using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class FoundationGadgetEntity : ScriptGadgetEntity
    {
        internal FoundationGadgetEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            FoundationInfo foundation = new()
            {
                //CurrentBuildingId =,
                //Status =,
                //LockedByUid =,
            };
            //foundation.UidList.AddRange();

            info.Gadget.FoundationInfo = foundation;

            return info;
        }
    }
}