using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketProudSkillChangeNotify : BasePacket
    {
        public PacketProudSkillChangeNotify(Avatar avatar) : base(OpCode.ProudSkillChangeNotify)
        {
            ProudSkillChangeNotify proto = new()
            {
                AvatarGuid = avatar.Guid,
                EntityId = avatar.EntityId,
                SkillDepotId = avatar.CurSkillDepot.DepotId
            };
            foreach(uint id in avatar.CurSkillDepot.InherentProudSkillIds)
            {
                proto.ProudSkillList.Add(id);
            }
            Data = proto.ToByteArray();
        }
    }
}
