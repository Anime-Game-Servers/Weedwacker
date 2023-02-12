using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByBigTeamHasElementType : ConfigAbilityPredicate
{
	public ElementType elementType;
	public uint number;
	public RelationalOperator logic;
}
