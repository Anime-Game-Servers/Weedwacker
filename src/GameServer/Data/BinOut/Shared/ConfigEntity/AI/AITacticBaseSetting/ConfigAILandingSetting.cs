
namespace Weedwacker.GameServer.Data;

public class ConfigAILandingSetting : ConfigAITacticBaseSetting
{
	public ConfigAILandingData defaultSetting;
	public Dictionary<int, ConfigAILandingData> specification;

	public class ConfigAILandingData
	{
		public int speedLevel;
		public float landingAngleMax;
		public float landingAngleMin;
		public float landingTerrainAltitude;
	}
}