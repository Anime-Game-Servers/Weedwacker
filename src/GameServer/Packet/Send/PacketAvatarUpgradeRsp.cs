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
    internal class PacketAvatarUpgradeRsp : BasePacket
    {
        public PacketAvatarUpgradeRsp(Avatar avatar, uint oldLevel, Dictionary<FightProperty, float> oldFightPropMap) : base(OpCode.AvatarUpgradeRsp)
        {

            AvatarUpgradeRsp proto = new()
            {
                AvatarGuid = avatar.Guid,
                OldLevel = oldLevel,
                CurLevel = avatar.Level
            };
            foreach(var x in oldFightPropMap)
            {
                proto.OldFightPropMap.Add((uint)x.Key, x.Value);
            }
            foreach(var prop in avatar.FightProp)
            {
                proto.CurFightPropMap.Add((uint)prop.Key, prop.Value);
            }

            Data = proto.ToByteArray();
        }
    }
}
