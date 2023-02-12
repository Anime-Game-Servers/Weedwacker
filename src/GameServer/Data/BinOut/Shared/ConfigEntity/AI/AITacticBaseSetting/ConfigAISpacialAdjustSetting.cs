using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAISpacialAdjustSetting : ConfigAITacticBaseSetting
{
	public ConfigAISpacialAdjustData defaultSetting;
	public Dictionary<int, ConfigAISpacialAdjustData> specification;

	public class ConfigAISpacialAdjustData
	{
		public int speedLevel;
		public float yLow;
		public float yHigh;
	}
}