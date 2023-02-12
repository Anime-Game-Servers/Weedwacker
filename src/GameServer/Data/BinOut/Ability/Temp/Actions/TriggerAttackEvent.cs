using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerAttackEvent : ConfigAbilityAction
{
	public ConfigAttackEvent attackEvent;
	public TargetType targetType;
	public EntityType[] entityTypes;
	public bool isReject;
}
