using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetAnimatorBool : ConfigAbilityAction
{
	public string boolID;
	public bool value;
	public bool persistent;
}
