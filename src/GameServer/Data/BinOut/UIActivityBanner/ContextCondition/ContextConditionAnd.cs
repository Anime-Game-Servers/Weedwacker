using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextConditionAnd : ContextCondition
{
	public ContextCondition[] conditions;
}