using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideDoActionByPredicate : ConfigGuideAction
{
	public ConfigGuideCondition[][] predicates;
	public ConfigGuideAction[] actions;
}