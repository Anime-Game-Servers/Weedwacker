using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLogoPageSetting
{
	public ConfigLogoPage defaultConfig;
	public Dictionary<string, ConfigLogoPage> logoConfigMap;
	public string logoFolderPath;
	public string tipImgAWFolderPath;

	public class ConfigLogoPage
	{
		public string channelName;
		public string logoFileName;
		public bool showTipText;
		public string tipTextMapID;
		public bool showTipImgAW;
		public string tipImgAWName;
		public bool showWarningView;
		public string warningTitle;
		public string warningDesc;
		public bool showKoranTipsView;
		public string koranTipsDesc;
	}
}