using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarPromoteRsp : BasePacket
    {
        public PacketAvatarPromoteRsp(ulong guid) : base(OpCode.AvatarUpgradeRsp)
        {

            AvatarPromoteRsp proto = new()
            {
                Guid = guid
            };

            Data = proto.ToByteArray();
        }
    }
}
