using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideUIMaskAction : ConfigGuideAction
{
	public ConfigGuideWidgetContent[] widgetList;
	public string topInfo;
	public string[] prefabList;
	public bool clickToClose;
	public bool needSave;
	public ConfigGuideContextListType contextListType;
	public string pageShowPrefabAndGlobalHint;

	public class ConfigGuideWidgetContent
	{
		public string path;
		public string contextName;
		public string hintInfo;
		public string widghtInfo;
		public string warningInfo;
		public string[] whiteContextList;
		public InputActionType[] actionInfoList;
		public ConfigInputHint[] inputHintList;
		public WidgetInfoPos widghtInfoPos;
		public MaskGuideType maskType;
		public bool maskPassEasyTouch;
		public ButtonGuideType type;
		public float xOffset;
		public float yOffset;
		public float hintOffset;
		public GuideWidgetSpecialType special;
		public float value;
		public string valueStr;
		public GuidePageType pageType;
		public int maskIndex;
		public bool keepScale;
		public GuideGeneralConditionType generalConditionType;
		public bool generalConditionVal;

		public class ConfigInputHint
		{
			public string hintInfo;
			public InputActionType[] actionInfoList;
		}
	}
}