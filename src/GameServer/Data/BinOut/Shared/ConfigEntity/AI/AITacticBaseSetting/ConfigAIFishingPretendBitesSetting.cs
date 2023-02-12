using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIFishingPretendBitesSetting : ConfigAITacticBaseSetting
{
	public ConfigAIFishingPretendBitesData defaultSetting;
	public Dictionary<int, ConfigAIFishingPretendBitesData> specification;

	public class ConfigAIFishingPretendBitesData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float minPretendDistance;
		public float maxPretendDistance;
		public float cd;
	}
}