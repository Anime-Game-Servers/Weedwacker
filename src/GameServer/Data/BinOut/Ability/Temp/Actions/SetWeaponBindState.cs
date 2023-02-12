using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetWeaponBindState : ConfigAbilityAction
{
	public bool place;
	public string equipPartName;
	public ConfigBornType born;
}
