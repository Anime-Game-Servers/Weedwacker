using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideButtonClickCondition : ConfigGuideCondition
{
	public string buttonPath;
	public string contextName;
	public GuidePageType pageType;
	public GuideButtonClick type;
	public float value;
	public GuideWidgetSpecialType special;
	public int specialIndex;
	public GuideLongPressType longPressType;
	public bool forceLastClick;
}