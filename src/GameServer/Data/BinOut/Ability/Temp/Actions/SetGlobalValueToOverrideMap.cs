using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetGlobalValueToOverrideMap : ConfigAbilityAction
{
	public AbilityFormula abilityFormula;
	public bool isFromOwner;
	public string globalValueKey;
	public string overrideMapKey;
}
