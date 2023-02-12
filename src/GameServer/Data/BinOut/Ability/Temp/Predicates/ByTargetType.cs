using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetType : ConfigAbilityPredicate
{
	public AbilityTargetting targetType;
	public bool isTarget;
}
