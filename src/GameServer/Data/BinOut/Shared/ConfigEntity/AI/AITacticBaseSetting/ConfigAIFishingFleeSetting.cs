using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIFishingFleeSetting : ConfigAITacticBaseSetting
{
	public ConfigAIFishingFleeData defaultSetting;
	public Dictionary<int, ConfigAIFishingFleeData> specification;

	public class ConfigAIFishingFleeData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float fleeAngle;
		public float fleeDuration;
		public float fleeDistanceMin;
		public float fleeDistanceMax;
		public bool turnToTarget;
		public bool restrictedByDefendArea;
		public bool expandFleeAngleWhenBlocked;
	}
}