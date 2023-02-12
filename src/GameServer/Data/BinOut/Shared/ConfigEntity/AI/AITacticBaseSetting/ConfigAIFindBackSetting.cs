using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIFindBackSetting : ConfigAITacticBaseSetting
{
	public ConfigAIFindBackData defaultSetting;
	public Dictionary<int, ConfigAIFindBackData> specification;

	public class ConfigAIFindBackData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float cd;
		public float overtime;
		public float targetLRSpace;
		public float targetBackSpace;
	}
}