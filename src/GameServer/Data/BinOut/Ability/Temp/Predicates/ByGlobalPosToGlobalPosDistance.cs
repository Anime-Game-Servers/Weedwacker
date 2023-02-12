using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

internal class ByGlobalPosToGlobalPosDistance : ConfigAbilityPredicate
{
	//guessed types
	public TargetPosToSelfPosType compareType;
	public RelationalOperator logic;
	public string positionKey1;
	public string positionKey2;
	public AbilityTargetting target;
	public object value;
}
