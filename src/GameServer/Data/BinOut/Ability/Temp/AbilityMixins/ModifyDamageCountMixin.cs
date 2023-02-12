using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ModifyDamageCountMixin : ConfigAbilityMixin
{
	public object maxModifyCount;
	public ConfigAbilityPredicate[] countPredicates;
	public bool isIgnoreAttenuation;
	public ConfigAbilityAction[] successActions;
	public ConfigAbilityAction[] maxCountActions;
}
