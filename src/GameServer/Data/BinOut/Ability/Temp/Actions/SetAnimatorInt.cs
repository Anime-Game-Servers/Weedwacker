using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetAnimatorInt : ConfigAbilityAction
{
	public string intID;
	public object value;
	public bool persistent;
}
