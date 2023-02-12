using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByCompareWithTarget : RelationalOperationPredicate
{
	public bool useOwner;
	public CompareProperty property;
}