using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionBySelfModifierElementDurabilityRatioMixin : ConfigAbilityMixin
{
	public string uniqueModifierName;
	public object[] valueSteps;
	public ConfigAbilityAction[][] actionQueues;
}
