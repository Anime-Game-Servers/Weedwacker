using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSteerInterAction : ConfigBaseInterAction
{
	public DialogSteerType steerType;
	public bool useAngle;
	public Vector steerDir;
	public float steerAngle;
	public bool useSteerAnim;
	public bool interruptFreestyle;
	public bool forceSteer;
	public string targetNpcAlias;
}