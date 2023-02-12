using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLookAtInterAction : ConfigBaseInterAction
{
	public bool enableHead;
	public bool useTargetPos;
	public bool enableAbsolute;
	public Vector targetOffset;
	public Vector targetPosition;
	public Vector headRotateVec;
	public bool enableBody;
	public float bodyAngle;
	public float headTurnTime;
	public float bodyTurnTime;
	public string targetNpcAlias;
	public LookAtTargetType lookAtTargetType;
	public Vector targetNpcRotateVecPlus;
	public bool openBackProtect;
	public float backProtectAngle;
}