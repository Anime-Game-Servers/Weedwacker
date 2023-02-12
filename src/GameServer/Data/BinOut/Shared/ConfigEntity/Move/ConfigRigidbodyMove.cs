using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType;

public class ConfigRigidbodyMove : ConfigMove
{
	public float constSpeedRatio;
	public bool startCloseToGround;
	public bool enableCloseToGroundWhenTick;
	public bool followReferenceSystem;
	public bool useAniamtorVelocity;
	public bool enableSyncTransToServer;
	public bool ignoreEnableRigidbodyDist;
}
