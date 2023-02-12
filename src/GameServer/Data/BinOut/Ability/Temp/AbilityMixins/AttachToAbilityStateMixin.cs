using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachToAbilityStateMixin : ConfigAbilityMixin
{
	public AbilityState[] abilityStates;
	public bool reject;
	public string modifierName;
}
