using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerHideWeapon : ConfigAbilityAction
{
	public bool visible;
	public string[] partNames;
	public bool modifyAnotherValue;
}
