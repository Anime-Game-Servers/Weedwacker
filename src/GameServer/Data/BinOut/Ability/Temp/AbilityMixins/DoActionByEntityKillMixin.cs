using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByEntityKillMixin : ConfigAbilityMixin
{
	public ConfigAbilityPredicate[] predicates;
	public ConfigAbilityAction[] actionQueue;
}
