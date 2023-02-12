using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIFleeSetting : ConfigAITacticBaseSetting
{
	public ConfigAIFleeData defaultSetting;
	public Dictionary<int, ConfigAIFleeData> specification;

	public class ConfigAIFleeData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float cd;
		public float triggerDistance;
		public float fleeAngle;
		public int fleeNumberMin;
		public int fleeNumberMax;
		public float fleeDistanceMin;
		public float fleeDistanceMax;
		public bool turnToTarget;
		public bool restrictedByDefendArea;
		public bool expandFleeAngleWhenBlocked;
		public float killSelfTime;
	}
}