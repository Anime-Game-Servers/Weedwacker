using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ChangeTag : ConfigAbilityAction
{
	public bool isAdd;
	public string tag;
}
