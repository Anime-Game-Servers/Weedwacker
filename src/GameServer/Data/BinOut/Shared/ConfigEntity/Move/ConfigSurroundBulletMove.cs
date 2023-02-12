using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

public class ConfigSurroundBulletMove : ConfigBulletMove
{
	public bool clockwise;
	public float radius;
	public bool traceOnYAxis;
	public bool destroyWhenTargetDie;
}
