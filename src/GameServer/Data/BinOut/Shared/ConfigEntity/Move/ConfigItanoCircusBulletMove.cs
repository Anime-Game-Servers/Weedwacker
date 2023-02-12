using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

public class ConfigItanoCircusBulletMove : ConfigBulletMove
{
	public float itanoCircusStartAngler;
	public bool destroyWhenTargetDie;
	public float guidanceDelay;
	public bool guidanceSpeedChange;
	public float guidanceMinAnglerVelocity;
	public float guidanceDuration;
}
