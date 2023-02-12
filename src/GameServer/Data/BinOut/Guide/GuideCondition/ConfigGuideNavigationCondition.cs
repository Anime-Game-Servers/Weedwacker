using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideNavigationCondition : ConfigGuideCondition
{
	public uint navigationId;
	public GuideNavigationType navigationType;
	public GuideNavigationCheckType checkType;
	public bool onlyCheckChange;
}