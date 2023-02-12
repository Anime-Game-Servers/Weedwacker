using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigActivityBanner
{
	public Dictionary<string, ContextCondition> conditionDefines;
	public Dictionary<string, ContextAction> actionDefines;
	public ContextConditionActionGroup[] updateGroups;
	public ContextConditionActionGroup[] clickGroups;

	public class ContextConditionActionGroup
	{
		public string conditionName;
		public string actionName;
	}
}