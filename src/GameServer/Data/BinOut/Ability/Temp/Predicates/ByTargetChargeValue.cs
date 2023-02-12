using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;
public class ByTargetChargeValue : ConfigAbilityPredicate
{
	public ElementType element;
	public string globalValueKey;
	public object value;
	public RelationType compareType;
}