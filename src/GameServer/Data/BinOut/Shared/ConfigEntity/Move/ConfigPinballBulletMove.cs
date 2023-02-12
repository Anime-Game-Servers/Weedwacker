using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

internal class ConfigPinballBulletMove : ConfigBulletMove 
{
	public float radius;
	public bool traceOnYAxis;
	public bool destroyWhenTargetDie;
	public float randomBackAngleAdded;
	public float reboundInterval;
	public float outOfRangeFixCD;
}
