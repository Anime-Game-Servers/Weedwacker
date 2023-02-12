using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetGlobalPos : ConfigAbilityAction
{
	public string key;
	public ConfigBornType born;
	public bool setTarget;
}
