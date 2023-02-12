using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ConnectLineMixin : ConfigAbilityMixin
{
	public string RepeaterModifier;
	public string CollectorModifier;
	public string CollectorGlobalvalueKey;
	public SelectTargets otherTargets;
	public ConfigAbilityPredicate[] predicates;
	public ConfigAbilityPredicate[] predicatesForeach;
}
