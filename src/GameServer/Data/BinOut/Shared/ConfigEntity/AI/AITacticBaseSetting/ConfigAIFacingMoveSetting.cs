using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIFacingMoveSetting : ConfigAITacticBaseSetting
{
	public ConfigAIFacingMoveData defaultSetting;
	public Dictionary<int, ConfigAIFacingMoveData> specification;

	public class ConfigAIFacingMoveData
	{
		public int speedLevel;
		public float rangeMin;
		public float rangeMax;
		public float restTimeMin;
		public float restTimeMax;
		public float facingMoveTurnInterval;
		public float facingMoveMinAvoidanceVelecity;
		public float obstacleDetectRange;
		public ConfigAIFacingMoveWeight facingMoveWeight;

		public class ConfigAIFacingMoveWeight
		{
			public float stop;
			public float forward;
			public float back;
			public float left;
			public float right;
		}
	}
}