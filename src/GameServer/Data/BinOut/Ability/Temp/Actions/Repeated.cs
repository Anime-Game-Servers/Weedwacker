using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class Repeated : ConfigAbilityAction
{
	public object repeatTimes;
	public ConfigAbilityAction[] actions;
}
