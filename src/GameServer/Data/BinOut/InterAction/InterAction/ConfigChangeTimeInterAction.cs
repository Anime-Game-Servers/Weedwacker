using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigChangeTimeInterAction : ConfigBaseInterAction
{
	public float toTime;
	public uint extraDay;
	public bool force;
	public bool useFade;
	public float fadeSpeed;
}