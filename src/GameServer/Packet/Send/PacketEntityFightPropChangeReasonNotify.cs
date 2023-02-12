using Google.Protobuf;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send;

internal class PacketEntityFightPropChangeReasonNotify : BasePacket
{
	public PacketEntityFightPropChangeReasonNotify(SceneEntity entity, FightPropType prop, float value,
		 PropChangeReason reason, ChangeHpReason changeHpReason = ChangeHpReason.None, IEnumerable<uint>? param = null) : base(OpCode.EntityFightPropChangeReasonNotify)
	{
		EntityFightPropChangeReasonNotify proto = new()
		{
			EntityId = entity.EntityId,
			PropType = (uint)prop,
			PropDelta = value,
			Reason = reason,
			ChangeHpReason = changeHpReason
		};
		if (param != null)
			param.AsParallel().ForAll(w => proto.ParamList.Add(w));

		Data = proto.ToByteArray();
	}

	public PacketEntityFightPropChangeReasonNotify(SceneEntity entity, FightPropType prop, float value,
		ChangeHpReason changeHpReason, IEnumerable<uint>? param = null) : base(OpCode.EntityFightPropChangeReasonNotify)
	{
		EntityFightPropChangeReasonNotify proto = new()
		{
			EntityId = entity.EntityId,
			PropType = (uint)prop,
			PropDelta = value,
			ChangeHpReason = changeHpReason
		};
		if (param != null)
			param.AsParallel().ForAll(w => proto.ParamList.Add(w));

		Data = proto.ToByteArray();
	}

	public PacketEntityFightPropChangeReasonNotify(SceneEntity entity, FightPropType prop, float value,
		ChangeEnergyReason changeEnergyReason, IEnumerable<uint>? param = null) : base(OpCode.EntityFightPropChangeReasonNotify)
	{
		EntityFightPropChangeReasonNotify proto = new()
		{
			EntityId = entity.EntityId,
			PropType = (uint)prop,
			PropDelta = value,
			ChangeEnergyReason = changeEnergyReason
		};
		if (param != null)
			param.AsParallel().ForAll(w => proto.ParamList.Add(w));

		Data = proto.ToByteArray();
	}
}
