using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class OfferingGadgetEntity : ScriptGadgetEntity
    {
        internal OfferingGadgetEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            OfferingInfo offeringInfo = new()
            {
                //OfferingId = default
            };
            info.Gadget.OfferingInfo = offeringInfo;

            return info;
        }
    }
}