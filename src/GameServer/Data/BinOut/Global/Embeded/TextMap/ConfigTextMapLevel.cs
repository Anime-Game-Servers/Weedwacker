using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigTextMapLevel
{
	public Dictionary<int, TextMapLevelStruct> levelMap;
	public Dictionary<TextMapPlatformType, int> platformMap;

	public class TextMapLevelStruct
	{
		public int minFileNum;
		public int maxFileNum;
		public int autoChangeStep;
	}
}