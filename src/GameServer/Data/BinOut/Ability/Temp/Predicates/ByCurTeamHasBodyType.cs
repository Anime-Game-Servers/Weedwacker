using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByCurTeamHasBodyType : ConfigAbilityPredicate
{
	public string bodyType;
	public uint number;
	public RelationalOperator logic;
}