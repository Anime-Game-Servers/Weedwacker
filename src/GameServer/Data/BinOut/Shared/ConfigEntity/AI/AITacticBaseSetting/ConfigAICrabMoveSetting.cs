
namespace Weedwacker.GameServer.Data;

public class ConfigAICrabMoveSetting : ConfigAITacticBaseSetting
{
	public ConfigAICrabMoveData defaultSetting;
	public Dictionary<int, ConfigAICrabMoveData> specification;

	public class ConfigAICrabMoveData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float radiusMin;
		public float radiusMax;
		public float moveTimeMin;
		public float moveTimeMax;
		public float restTimeMin;
		public float restTimeMax;
		public float detectFrontDistance;
	}
}