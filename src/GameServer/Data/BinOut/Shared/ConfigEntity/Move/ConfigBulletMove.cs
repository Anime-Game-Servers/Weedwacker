using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

public class ConfigBulletMove : ConfigMove
{
	public float speed;
	public float maxSpeed;
	public float minSpeed;
	public float anglerVelocity;
	public float acceleration;
	public float accelerationTime;
	public bool canBornInWater;
	public ConfigBulletMoveAngle updateAngle;
	public float delay;
	public ConfigMoveStickToGround stickToGround;
	public bool syncToRemote;
	public float blockedByMonsterRadius;

	public class ConfigMoveStickToGround
	{
		public float maxStepHeight;
		public float maxSlopeAngle;
		public float heightToGround;
		public float flexibleRange;
		public bool isStickToWater;
		public bool ignoreBarrier;
		public UnstickAction unstickWhenDownSlide;
		public UnstickAction unstickWhenUpSlide;
	}
}
