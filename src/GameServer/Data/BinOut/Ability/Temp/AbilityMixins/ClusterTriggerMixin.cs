using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ClusterTriggerMixin : ConfigAbilityMixin
{
	public ConfigBornType born;
	public uint configID;
	public float radius;
	public float duration;
	public object[] valueSteps;
	public ConfigAbilityAction[] actionQueue;
}