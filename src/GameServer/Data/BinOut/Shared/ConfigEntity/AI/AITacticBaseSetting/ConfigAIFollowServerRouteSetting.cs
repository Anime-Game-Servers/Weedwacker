using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIFollowServerRouteSetting : ConfigAITacticBaseSetting
{
	public ConfigAIFollowServerRouteData defaultSetting;
	public Dictionary<int, ConfigAIFollowServerRouteData> specification;

	public class ConfigAIFollowServerRouteData
	{
		public int speedLevel;
		public float turnSpeedOverrideWalk;
		public float turnSpeedOverrideRun;
		public float checkRange;
		public bool special;
	}
}