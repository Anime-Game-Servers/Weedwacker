using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ServerLuaTriggerEvent : ConfigAbilityAction
{
	public LuaCallType luaCallType;
	public bool isTarget;
	public uint[] CallParamList;
	public string sourceName;
	public uint paramNum;
	public object param1;
	public object param2;
	public object param3;
}
