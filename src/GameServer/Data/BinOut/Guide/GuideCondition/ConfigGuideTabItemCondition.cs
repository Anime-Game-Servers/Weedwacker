using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideTabItemCondition : ConfigGuideCondition
{
	public string path;
	public string contextName;
	public int value;
	public GuidePageType pageType;
	public bool isSelect;
}