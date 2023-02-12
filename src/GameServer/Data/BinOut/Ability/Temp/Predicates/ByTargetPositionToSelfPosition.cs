using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetPositionToSelfPosition : RelationalOperationPredicate
{
	public TargetPosToSelfPosType compareType;
	public object value;
}