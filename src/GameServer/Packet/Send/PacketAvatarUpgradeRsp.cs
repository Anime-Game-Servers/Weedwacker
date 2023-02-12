using Google.Protobuf;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarUpgradeRsp : BasePacket
    {
        public PacketAvatarUpgradeRsp(Avatar avatar, uint oldLevel, Dictionary<FightPropType, float> oldFightPropMap) : base(OpCode.AvatarUpgradeRsp)
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
