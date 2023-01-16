using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.AvatarPromoteReq)]
    internal class HandleAvatarPromoteReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            AvatarPromoteReq req = AvatarPromoteReq.Parser.ParseFrom(payload);
            await session.Player.Avatars.PromoteAvatarAsync(req.Guid);
            await session.Player.SendPacketAsync(new PacketAvatarPromoteRsp(req.Guid));
        }
    }
}
