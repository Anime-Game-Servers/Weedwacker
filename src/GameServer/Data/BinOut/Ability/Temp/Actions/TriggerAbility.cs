using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerAbility : ConfigAbilityAction
{
	public string abilityName;
	public Dictionary<string, object> abilitySpecials;
	public bool forceUseSelfCurrentAttackTarget;
}
