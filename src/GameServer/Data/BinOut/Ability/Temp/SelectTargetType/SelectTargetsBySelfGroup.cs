using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType;

public class SelectTargetsBySelfGroup : SelectTargets
{
	public BitwiseOperator operation;
	public uint value;
	public object dynamicValue;
	public bool useBinary;
	public RelationalOperator compareType;
}
