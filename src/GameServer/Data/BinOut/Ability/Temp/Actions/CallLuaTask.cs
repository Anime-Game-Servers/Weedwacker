using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class CallLuaTask : ConfigAbilityAction
{
	public string targetAlias;
	public int valueInt;
	public float valueFloat;
	public string valueString;
}
