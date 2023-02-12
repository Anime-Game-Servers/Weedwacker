using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigLookAtEyeCtrlInterAction : ConfigBaseInterAction
{
	public bool clearAll;
	public bool useTargetPos;
	public Vector targetPosition;
	public Vector eyeRotateVecLeft;
	public Vector eyeRotateVecRight;
	public float eyeScaleX;
	public float eyeScaleZ;
	public float turnTime;
	public string targetNpcAlias;
	public string targetPoint;
}