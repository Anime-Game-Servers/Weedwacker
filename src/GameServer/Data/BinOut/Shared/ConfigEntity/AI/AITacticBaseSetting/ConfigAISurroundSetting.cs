
namespace Weedwacker.GameServer.Data;

public class ConfigAISurroundSetting : ConfigAITacticBaseSetting
{
	public ConfigAISurroundData defaultSetting;
	public Dictionary<int, ConfigAISurroundData> specification;

	public class ConfigAISurroundData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float startDistance;
		public float surroundRadius;
		public string[] turningStates;
		public float detectFrontDistance;
		public float detectFrontOffsetUp;
		public float detectFrontOffsetForward;
	}
}