
namespace Weedwacker.GameServer.Data;

public class ConfigAIPatrolFollowSetting : ConfigAITacticBaseSetting
{
	public ConfigAIPatrolFollowData defaultSetting;
	public Dictionary<int, ConfigAIPatrolFollowData> specification;

	public class ConfigAIPatrolFollowData
	{
		public int speedLevel;
		public float innerDistance;
		public int speedLevelInner;
		public float outDistance;
		public float stopDistance;
	}
}