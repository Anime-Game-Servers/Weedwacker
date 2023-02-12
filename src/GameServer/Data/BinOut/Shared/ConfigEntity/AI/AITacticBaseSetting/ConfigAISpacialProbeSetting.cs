using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAISpacialProbeSetting : ConfigAITacticBaseSetting
{
	public ConfigAISpacialProbeData defaultSetting;
	public Dictionary<int, ConfigAISpacialProbeData> specification;

	public class ConfigAISpacialProbeData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float cdMax;
		public float cdMin;
		public float terrainOffsetMin;
		public float terrainOffsetMax;
		public float distanceFromBorn;
		public float distanceFromCurrentMin;
		public float distanceFromCurrentMax;
		public int probeNumberMin;
		public int probeNumberMax;
	}
}