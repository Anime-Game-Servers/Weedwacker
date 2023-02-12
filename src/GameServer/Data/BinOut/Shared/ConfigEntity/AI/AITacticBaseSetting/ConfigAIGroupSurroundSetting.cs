
namespace Weedwacker.GameServer.Data;

public class ConfigAIGroupSurroundSetting : ConfigAITacticBaseSetting
{
	public ConfigAIGroupSurroundData defaultSetting;
	public Dictionary<int, ConfigAIGroupSurroundData> specification;

	public class ConfigAIGroupSurroundData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float startDistance;
		public float surroundRadius;
		public string[] turningStates;
		public float detectFrontDistance;
		public float detectFrontOffsetUp;
		public float cd;
		public float exitDistanceMax;
		public float exitDistanceMin;
		public float clockWiseWeight;
		public float detectCollisionRadius;
		public float detectCollisionDistance;
	}
}