using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.AvatarUpgradeReq)]
    internal class HandleAvatarUpgradeReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            AvatarUpgradeReq req = AvatarUpgradeReq.Parser.ParseFrom(payload);
            Avatar oldAvatar = session.Player.Avatars.AvatarsGuid[req.AvatarGuid];
            uint oldLevel = oldAvatar.Level;
            Dictionary<FightPropType, float> oldPropMap = new(oldAvatar.FightProp);
            Avatar newAvatar = await session.Player.Avatars.UpgradeAvatarAsync(req.AvatarGuid, req.ItemId, req.Count);
            await session.SendPacketAsync(new PacketAvatarUpgradeRsp(newAvatar, oldLevel, oldPropMap));
        }
    }
}
