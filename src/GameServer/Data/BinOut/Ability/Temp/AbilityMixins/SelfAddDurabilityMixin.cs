using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class SelfAddDurabilityMixin : ConfigAbilityMixin
{
	public object value;
	public bool useLimitRange;
	public object maxValue;
	public object minValue;
	public float thinkInterval;
}
