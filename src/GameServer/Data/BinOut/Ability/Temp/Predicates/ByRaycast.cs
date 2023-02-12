using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

internal class ByRaycast : ConfigAbilityPredicate
{
	public RaycastType raycastType;
	public RelationType compareType;
	public float value;
}
