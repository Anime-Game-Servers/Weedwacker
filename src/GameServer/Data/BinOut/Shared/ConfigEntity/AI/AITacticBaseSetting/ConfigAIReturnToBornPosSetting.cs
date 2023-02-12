
namespace Weedwacker.GameServer.Data;

public class ConfigAIReturnToBornPosSetting : ConfigAITacticBaseSetting
{
	public ConfigAIReturnToBornPosData defaultSetting;
	public Dictionary<int, ConfigAIReturnToBornPosData> specification;

	public class ConfigAIReturnToBornPosData
	{
		public int speedLevel;
		public float fadeoutBeginTime;
		public float fadeoutEndTime;
		public bool spacial;
		public float performTime;
	}
}