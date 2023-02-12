using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class Predicated : ConfigAbilityAction
{
	public ConfigAbilityPredicate[] targetPredicates;
	public ConfigAbilityAction[] successActions;
	public ConfigAbilityAction[] failActions;
}
