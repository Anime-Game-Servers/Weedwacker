using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSimpleUIShowInterAction : ConfigBaseInterAction
{
	public string contextName;
	public bool isClose;
	public string param;
	public string[] multiParam;
}