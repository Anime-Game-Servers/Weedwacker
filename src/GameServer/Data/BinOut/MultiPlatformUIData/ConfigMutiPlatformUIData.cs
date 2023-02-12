using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMutiPlatformUIData
{
	public Dictionary<string, ConfigPlatformUIData> multiPlatform;

	public class ConfigPlatformUIData
	{
		public ConfigPlatformUIAction baseCanvansAction;
		public ConfigPlatformUIAction basePageAction;
		public Dictionary<string, ConfigPlatformUIAction> contextActions;

		public class ConfigPlatformUIAction
		{
			public string[] paths;
			public float indent;
			public float scale;
			public float top;
			public float bottom;
			public float left;
			public float right;
			public float posx;
			public float posy;
			public int active;
			public int firstActive;
			public string animation;
		}
	}
}