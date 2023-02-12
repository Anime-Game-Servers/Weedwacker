using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

public class ConfigAnimatorMove : ConfigMove
{
	public bool initWithGroundHitCheck;
	public ConfigMoveSmoothedSpeed smoothedSpeed;
	public bool moveOnGround;
	public bool moveOnWater;
	public float moveOnWaterDepth;
	public ConfigRaycast[] raycasts;
	public FacingMoveType facingMove;
	public FacingMoveType airFacingMove;
	public MonsterSizeType monsterSizeType;
	public PositionModifyState positionModifyState;
	public Dictionary<uint, PositionModifyState> positionModifyStateMap;
	public bool destroyRockWhenInit;
	public float yawSpeedRatio;
	public float velocityRatio;
	public string[] launchStates;
	public string[] landStates;
	public bool positionModifyExtra;

	public class ConfigRaycast
	{
		public float raycastLength;
		public RaycastType raycastType;
	}
	public class ConfigMoveSmoothedSpeed
	{
		public float maxSpeed;
		public float accelerationXZ;
		public float accelerationY;
		public float zeroingSpeedXZ;
		public float zeroingSpeedY;
	}
}
