using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class AbilityGadgetEntity : BaseGadgetEntity
    {
        private uint CampId;
        private uint CampType;
        private uint TargetEntityId;
        internal AbilityGadgetEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();
            AbilityGadgetInfo abilityGadget = new()
            {
                CampId = CampId,
                CampTargetType = CampType,
                TargetEntityId = TargetEntityId
            };
            info.Gadget.AbilityGadget = abilityGadget;

            return info;
        }
    }
}
