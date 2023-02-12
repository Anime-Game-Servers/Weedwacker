using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerThrowEquipPart : ConfigAbilityAction
{
	public string equipPart;
	public bool chaseAttackTarget;
	public ConfigBornType born;
}
