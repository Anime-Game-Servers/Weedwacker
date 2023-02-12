using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSetAnimatorAction : ConfigBaseInterAction
{
	public AnimatorParamType2 paramType;
	public string paramName;
	public int intValue;
	public float floatValue;
	public bool boolValue;
}