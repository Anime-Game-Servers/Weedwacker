using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAISpacialWanderSetting : ConfigAITacticBaseSetting
{
	public ConfigAISpacialWanderData defaultSetting;
	public Dictionary<int, ConfigAISpacialWanderData> specification;

	public class ConfigAISpacialWanderData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public string[] turningStates;
		public float cdMax;
		public float cdMin;
		public float terrainOffsetMin;
		public float terrainOffsetMax;
		public float distanceFromBorn;
		public float distanceFromCurrentMin;
		public float distanceFromCurrentMax;
		public float distanceFromEdge;
		public float coneAngleThreshold;
		public ConfigAISpacialWanderConeWeightData coneWeight;

		public class ConfigAISpacialWanderConeWeightData
		{
			public uint[] normalAreaWeight;
			public uint[] edgeAreaWeight;
		}
	}
}