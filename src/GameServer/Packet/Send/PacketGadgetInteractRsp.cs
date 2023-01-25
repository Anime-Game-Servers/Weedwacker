using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketGadgetInteractRsp : BasePacket
    {
        public PacketGadgetInteractRsp(uint gadgetId, uint gadgetEntityId, InteractType interactType, InterOpType? opType) : base(Enums.OpCode.GadgetInteractRsp)
        {
            GadgetInteractRsp proto = new GadgetInteractRsp()
            {
                GadgetId = gadgetId,
                GadgetEntityId = gadgetEntityId,
                InteractType = interactType
            };
            if(opType != null)
            {
                proto.OpType = opType.Value;
            }

            Data = proto.ToByteArray();
        }
    }
}
