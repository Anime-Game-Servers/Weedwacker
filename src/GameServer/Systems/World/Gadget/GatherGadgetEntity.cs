using System;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class GatherGadgetEntity : ScriptGadgetEntity
    {
        private uint ItemId;
        private bool IsForbidGuest;
        internal GatherGadgetEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }


        public override SceneEntityInfo ToProto()
        {
            SceneEntityInfo info = base.ToProto();
            GatherGadgetInfo gatherInfo = new()
            {
                ItemId = ItemId,
                IsForbidGuest = IsForbidGuest
            };
            info.Gadget.GatherGadget = gatherInfo;
            return info;
        }
    }
}
