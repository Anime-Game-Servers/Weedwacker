using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

public class ConfigSimpleMove : ConfigMove
{
	public float constSpeedRatio;
	public bool followReferenceSystem;
}
