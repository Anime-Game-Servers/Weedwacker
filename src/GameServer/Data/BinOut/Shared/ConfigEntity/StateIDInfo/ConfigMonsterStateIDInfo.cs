using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMonsterStateIDInfo : ConfigNormalStateIDInfo
{
	public bool enableBoneFollowMove;
	public bool canSteer;
	public bool autoSteer;
	public bool followAnimRotation;
	public float gravityAdjustScale;
	public bool forceSetAirMove;
	public bool remoteForceCloseAirMove;
	public bool remoteForceUseAnimatorVel;
	public BlendMoveType blendMove;
	public bool airMoveFollowAnimation;
}