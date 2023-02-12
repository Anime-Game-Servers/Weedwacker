using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class GetFightProperty : ConfigAbilityAction
{
	public AbilityTargetting fightPropSourceTarget;
	public string fightProp;
	public string globalValueKey;
}
