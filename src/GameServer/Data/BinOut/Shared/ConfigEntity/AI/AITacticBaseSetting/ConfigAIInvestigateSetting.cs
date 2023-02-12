using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIInvestigateSetting : ConfigAITacticBaseSetting
{
	public ConfigAIInvestigateData defaultSetting;
	public Dictionary<int, ConfigAIInvestigateData> specification;

	public class ConfigAIInvestigateData
	{
		public int speedLevel;
		public float lookAroundTime;
		public bool spacial;
	}
}