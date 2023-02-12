using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class FieldEntityCountChangeMixin : ConfigAbilityMixin
{
	public TargetType campTargetType;
	public bool forceTriggerWhenChangeAuthority;
	public ConfigAbilityPredicate[] targetPredicates;
	public ConfigAbilityAction[] onFieldEnter;
	public ConfigAbilityAction[] onFieldExit;
}
