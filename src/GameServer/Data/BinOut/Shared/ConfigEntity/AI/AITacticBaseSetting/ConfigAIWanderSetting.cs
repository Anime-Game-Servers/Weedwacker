using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIWanderSetting : ConfigAITacticBaseSetting
{
	public int[] threatLevelLimit;
	public ConfigAIWanderData defaultSetting;
	public Dictionary<int, ConfigAIWanderData> specification;

	public class ConfigAIWanderData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float cdMax;
		public float cdMin;
		public float distanceFromBorn;
		public float distanceFromCurrentMin;
		public float distanceFromCurrentMax;
		public AIBasicMoveType moveType;
	}
}