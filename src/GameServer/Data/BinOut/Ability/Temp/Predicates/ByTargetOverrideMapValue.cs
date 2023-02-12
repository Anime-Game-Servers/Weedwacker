using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetOverrideMapValue : RelationalOperationPredicate
{
	public string targetAbilityName;
	public string targetKey;
	public object targetValue;
}
