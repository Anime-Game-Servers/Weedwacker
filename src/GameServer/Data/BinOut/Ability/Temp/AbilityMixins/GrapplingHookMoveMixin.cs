using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class GrapplingHookMoveMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] onArrived;
	public float upForceValue;
	public float upForceTime;
	public float arriveDistance;
}