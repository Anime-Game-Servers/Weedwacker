
namespace Weedwacker.GameServer.Data;

public class ConfigAIExtractionSetting : ConfigAITacticBaseSetting
{
	public ConfigAIExtractionData defaultSetting;
	public Dictionary<int, ConfigAIExtractionData> specification;

	public class ConfigAIExtractionData
	{
		public int speedLevel;
		public float extractionDistance;
		public float extractionAngleMax;
		public float extractionAngleMin;
		public float triggerDistance;
		public float killSelfTime;
	}
}