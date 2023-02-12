using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextConditionOr : ContextCondition
{
	public ContextCondition[] conditions;
}