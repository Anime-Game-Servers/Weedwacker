using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByBigTeamHasFeatureTag : ConfigAbilityPredicate
{
	public uint featureTagID;
	public uint number;
	public RelationalOperator logic;
}