using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

public class ConfigTrackBulletMove : ConfigBulletMove
{
	public bool destroyWhenTargetDie;
	public bool traceOnYAxis;
}
