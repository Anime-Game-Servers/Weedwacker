using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideTask
{
	public string name;
	public bool isFreshmanGuide;
	public ConfigGuideCondition[] predicates;
	public ConfigGuideCondition[] onCheck;
	public ConfigGuideAction[] onGuide;
	public ConfigGuideCondition[][] finishCondition;
	public ConfigGuideAction[] onFinish;
	public ConfigGuideAction[] onQuit;
}