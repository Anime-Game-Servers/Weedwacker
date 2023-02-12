using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

internal class ConfigLinerParabolaBulletMove : ConfigLinerBulletMove
{
	public float straightRange;
	public float gravityOfAcceleration;
	public float airResistance;
}
