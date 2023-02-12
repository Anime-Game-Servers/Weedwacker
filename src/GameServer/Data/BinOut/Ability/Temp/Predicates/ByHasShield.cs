using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByHasShield : ConfigAbilityPredicate
{
	public HasShieldType type;
	public bool usePotentShield;
	public ElementType potentShieldType;
}
