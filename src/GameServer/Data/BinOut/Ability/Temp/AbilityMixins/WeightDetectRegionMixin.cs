using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class WeightDetectRegionMixin : ConfigAbilityMixin
{
	public string globalValueKey;
	public ConfigAbilityAction[] onWeightChanged;
}
