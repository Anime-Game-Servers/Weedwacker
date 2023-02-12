using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class PushInterActionByConfigPath : ConfigAbilityAction
{
	public string cfgPath;
	public bool isExternal;
}
