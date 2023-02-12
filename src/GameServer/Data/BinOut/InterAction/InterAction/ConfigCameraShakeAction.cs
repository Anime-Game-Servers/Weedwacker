using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCameraShakeAction : ConfigBaseInterAction
{
	public float shakeRange;
	public float shakeTime;
	public float shakeDinstance;
	public Vector shakeDir;
}