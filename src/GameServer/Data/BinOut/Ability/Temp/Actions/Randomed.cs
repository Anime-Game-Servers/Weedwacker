using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class Randomed : ConfigAbilityAction
{
	public object chance;
	public ConfigAbilityAction[] successActions;
	public ConfigAbilityAction[] failActions;
}
