using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class WindZoneMixin : ConfigAbilityMixin
{
	public string shapeName;
	public ConfigBornType born;
	public object strength;
	public object attenuation;
	public object innerRadius;
	public bool reverse;
	public TargetType targetType;
	public ConfigAbilityPredicate[] predicates;
	public string modifierName;
	public uint maxNum;
	public float forceGrowth;
	public float forceFallen;
	public Vector offset;
	public VelocityForceType forceType;
	public float thinkInterval;
	public ConfigAbilityAction[] onThinkInterval;
	public float overrideWeight;
}
