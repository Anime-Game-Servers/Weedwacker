using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarPropNotify : BasePacket
    {
        public PacketAvatarPropNotify(Avatar avatar) : base(OpCode.AvatarPropNotify)
        {
            AvatarPropNotify proto = new ()
            {
                AvatarGuid = avatar.Guid,
            };
            proto.PropMap.Add((uint)PlayerProperty.PROP_LEVEL, avatar.Level);
            proto.PropMap.Add((uint)PlayerProperty.PROP_EXP, avatar.Exp);
            proto.PropMap.Add((uint)PlayerProperty.PROP_BREAK_LEVEL, avatar.PromoteLevel);
            proto.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_VAL, 0); //?
            proto.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, 0); //?
            Data = proto.ToByteArray();
        }
    }
}
