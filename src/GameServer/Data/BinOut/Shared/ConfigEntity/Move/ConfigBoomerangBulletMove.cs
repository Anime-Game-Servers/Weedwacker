using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.Move;

internal class ConfigBoomerangBulletMove : ConfigBulletMove
{
	public bool initClockwise;
	public float stickToGroundDuration;
	public bool traceOnYAxis;
	public bool destroyWhenTargetDie;
}
