using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetOverrideMapValue : ConfigAbilityAction
{
	public object value;
	public string overrideMapKey;
}
