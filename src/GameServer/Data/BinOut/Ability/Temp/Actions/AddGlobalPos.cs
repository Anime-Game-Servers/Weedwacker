using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AddGlobalPos : ConfigAbilityAction
{
	public string key;
	public ConfigBornType born;
	public bool setTarget;
}