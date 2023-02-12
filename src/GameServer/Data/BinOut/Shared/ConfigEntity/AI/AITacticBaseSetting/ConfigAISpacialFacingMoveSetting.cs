using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigAISpacialFacingMoveSetting : ConfigAITacticBaseSetting
{
	public ConfigAISpacialFacingMoveData defaultSetting;
	public Dictionary<int, ConfigAISpacialFacingMoveData> specification;

	public class ConfigAISpacialFacingMoveData
	{
		public int speedLevel;
		public float rangeRadiusMin;
		public float rangeRadiusMax;
		public float restTimeMin;
		public float restTimeMax;
		public float facingMoveTurnInterval;
		public float facingMoveMinAvoidanceVelecity;
		public float obstacleDetectRange;
		public float obstacleUpRange;
		public float obstacleMaxAngle;
		public ConfigAISpacialFacingMoveProbability spacialFacingMoveProbability;
		public ConfigAIRaycastCondition[] canStartRangeByRaycast;

		public class ConfigAISpacialFacingMoveProbability
		{
			public float stop;
			public float forward;
			public float right;
			public float up;
			public float forwardMin;
			public float forwardMax;
			public float backMin;
			public float backMax;
			public float rightMin;
			public float rightMax;
			public float leftMin;
			public float leftMax;
			public float upMin;
			public float upMax;
			public float downMin;
			public float downMax;
			public float bestHeight;
			public float minHeight;
			public float maxHeight;
		}
	}
}