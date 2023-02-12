using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByStateIDMixin : ConfigAbilityMixin
{
	public string[] stateIDs;
	public ConfigAbilityPredicate[] enterPredicates;
	public ConfigAbilityPredicate[] exitPredicates;
	public ConfigAbilityAction[] enterActions;
	public ConfigAbilityAction[] exitActions;
}
