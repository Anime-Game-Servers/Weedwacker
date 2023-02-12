using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIBirdCirclingSetting : ConfigAITacticBaseSetting
{
	public ConfigAIBirdCirclingData defaultSetting;
	public Dictionary<int, ConfigAIBirdCirclingData> specification;

	public class ConfigAIBirdCirclingData
	{
		public int speedLevel;
		public float radius;
	}
}