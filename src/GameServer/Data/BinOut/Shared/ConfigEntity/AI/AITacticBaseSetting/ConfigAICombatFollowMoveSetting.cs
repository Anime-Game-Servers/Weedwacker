using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAICombatFollowMoveSetting : ConfigAITacticBaseSetting
{
	public ConfigAICombatFollowMoveData defaultSetting;
	public Dictionary<int, ConfigAICombatFollowMoveData> specification;

	public class ConfigAICombatFollowMoveData
	{
		public float startDistance;
		public float stopDistance;
		public float middleDistance;
		public float innerDistance;
		public int speedLevelOuter;
		public int speedLevelMiddle;
		public int speedLevelInner;
		public float startAngle;
		public float outerAngle;
		public float turnSpeedOverride;
		public float turnSpeedOverrideOuter;
		public bool useMeleeSlot;
		public float moveOutDampRange;
	}
}