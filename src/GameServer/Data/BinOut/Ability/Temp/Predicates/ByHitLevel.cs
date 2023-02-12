using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

internal class ByHitLevel : ConfigAbilityPredicate
{
	//guessed types
	public HitLevel hitLevel;
	public RelationalOperator logic;
}
