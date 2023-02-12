using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetTeamFightPropertyToOverrideMapKey : ConfigAbilityAction
{
	public string fightProperty;
	public string overrideMapKey;
}
