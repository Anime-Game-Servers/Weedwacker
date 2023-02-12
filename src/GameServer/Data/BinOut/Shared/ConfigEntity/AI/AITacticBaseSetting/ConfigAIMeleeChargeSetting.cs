using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIMeleeChargeSetting : ConfigAITacticBaseSetting
{
	public ConfigAIMeleeChargeData defaultSetting;
	public Dictionary<int, ConfigAIMeleeChargeData> specification;

	public class ConfigAIMeleeChargeData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float startDistanceMin;
		public float startDistanceMax;
		public float stopDistance;
		public float innerDistance;
		public int speedLevelInner;
		public bool useMeleeSlot;
	}
}