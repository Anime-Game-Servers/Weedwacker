using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.GadgetInteractReq)]
    internal class HandleGadgetInteractReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            GadgetInteractReq req = GadgetInteractReq.Parser.ParseFrom(payload);
            var gadget = session.Player.Scene.GetEntityById(req.GadgetEntityId) as BaseGadgetEntity;
            if (gadget is null)
                return;
            await gadget.OnInteractAsync(session.Player, req);
            await session.Player.Scene?.BroadcastPacketAsync(new PacketGadgetInteractRsp(req.GadgetId, req.GadgetEntityId, gadget.InteractType, null));
        }
    }
}
