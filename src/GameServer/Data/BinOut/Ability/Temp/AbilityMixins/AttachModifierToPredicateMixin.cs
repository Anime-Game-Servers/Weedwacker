using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierToPredicateMixin : ConfigAbilityMixin
{
	public AvatarStageType type;
	public OnEventType onEvent;
	public ConfigAbilityPredicate[] predicates;
	public string modifierName;
	public ConfigAbilityStateToActions[] onAbilityStateAdded;
	public ConfigAbilityStateToActions[] onAbilityStateRemoved;
}
