using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIFollowScriptedPathSetting : ConfigAITacticBaseSetting
{
	public ConfigAIFollowScriptedPathData defaultSetting;
	public Dictionary<int, ConfigAIFollowScriptedPathData> specification;

	public class ConfigAIFollowScriptedPathData
	{
		public float turnSpeedOverrideWalk;
		public float turnSpeedOverrideRun;
		public bool spacial;
		public bool spacialRoll;
	}
}