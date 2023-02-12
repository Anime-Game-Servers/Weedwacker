using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType.ConfigMoveCorrectionType;

public class ConfigParabolaBulletMoveCorrection : ConfigMoveCorrection
{
	public float deviation;
	public float fixAngleOfVer;
	public float minSpeed;
	public float maxSpeed;
}
