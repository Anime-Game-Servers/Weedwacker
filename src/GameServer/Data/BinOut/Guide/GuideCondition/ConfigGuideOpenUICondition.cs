using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideOpenUICondition : ConfigGuideCondition
{
	public string contextName;
	public bool enable;
	public string[] activeList;
	public GuidePageType pageType;
}