using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerTaunt : ConfigAbilityAction
{
	public TauntLevel tauntLevel;
	public float careValue;
}
