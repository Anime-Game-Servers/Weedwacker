using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerDropEquipParts : ConfigAbilityAction
{
	public bool dropAll;
	public string[] equipParts;
}
