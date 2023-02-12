using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class EnablePartControl : ConfigAbilityAction
{
	public string[] partRootNames;
	public bool enable;
}
