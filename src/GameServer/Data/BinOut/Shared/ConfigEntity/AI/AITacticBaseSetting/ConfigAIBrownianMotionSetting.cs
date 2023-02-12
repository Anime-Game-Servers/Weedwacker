using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIBrownianMotionSetting : ConfigAITacticBaseSetting
{
	public ConfigAIBrownianMotionData defaultSetting;
	public Dictionary<int, ConfigAIBrownianMotionData> specification;

	public class ConfigAIBrownianMotionData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float moveCdMin;
		public float moveCdMax;
		public float terrainOffsetMin;
		public float terrainOffsetMax;
		public float motionRadius;
		public bool recalcCenterOnLeaveCurrentZone;
		public bool recalcCenterOnAttachPosChange;
	}
}