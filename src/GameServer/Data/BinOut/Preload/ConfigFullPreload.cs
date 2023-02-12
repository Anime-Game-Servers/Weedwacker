using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigFullPreload
{
	public ConfigPlatformPreloadMapping platformPreloadMapping;
	public ConfigPreload commonPreload;
	public Dictionary<uint, ConfigPreload> entitiesPreload;

	public class ConfigPlatformPreloadMapping
	{
		public Dictionary<ConfigPreloadType, ConfigPreloadType[]> editor;
		public Dictionary<ConfigPreloadType, ConfigPreloadType[]> win;
		public Dictionary<ConfigPreloadType, ConfigPreloadType[]> android;
		public Dictionary<ConfigPreloadType, ConfigPreloadType[]> ps4;
		public Dictionary<ConfigPreloadType, ConfigPreloadType[]> ios;
	}
	public class ConfigPreload
	{
		public Dictionary<ConfigPreloadType, string[]> effects;
		public Dictionary<ConfigPreloadType, string[]> abilities;
		public Dictionary<ConfigPreloadType, string[]> gadgets;
		public Dictionary<ConfigPreloadType, string[]> cameras;
		public Dictionary<ConfigPreloadType, string[]> animEventPatterns;
		public Dictionary<ConfigPreloadType, string[]> skillIcons;
		public Dictionary<ConfigPreloadType, string[]> miscObjPaths;
		public Dictionary<ConfigPreloadType, string[]> weathers;
	}
}