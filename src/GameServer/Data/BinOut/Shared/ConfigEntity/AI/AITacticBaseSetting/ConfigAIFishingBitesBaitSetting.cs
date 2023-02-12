using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIFishingBitesBaitSetting : ConfigAITacticBaseSetting
{
	public ConfigAIFishingBitesBaitData defaultSetting;
	public Dictionary<int, ConfigAIFishingBitesBaitData> specification;

	public class ConfigAIFishingBitesBaitData
	{
		public int speedLevel;
		public float turnSpeedOverride;
	}
}