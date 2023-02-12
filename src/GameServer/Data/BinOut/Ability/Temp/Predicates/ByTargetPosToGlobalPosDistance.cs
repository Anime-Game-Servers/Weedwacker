using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

internal class ByTargetPosToGlobalPosDistance : ConfigAbilityPredicate
{
	//guessed types
	public TargetPosToSelfPosType compareType;
	public RelationalOperator logic;
	public float value;
	public string positionKey;
}
