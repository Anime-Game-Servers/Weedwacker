using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLuaAction : ConfigBaseInterAction
{
	public bool invoke;
	public string invokeAlias;
	public uint invokeParam;
}