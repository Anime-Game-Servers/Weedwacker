using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByIsTargetCamp : ConfigAbilityPredicate
{
	public AbilityTargetting campBaseOn;
	public TargetType campTargetType;
}
