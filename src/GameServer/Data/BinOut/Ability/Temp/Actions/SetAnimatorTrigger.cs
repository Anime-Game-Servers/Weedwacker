using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetAnimatorTrigger : ConfigAbilityAction
{
	public object triggerID;
	public bool MPTriggerOnRemote;
}
