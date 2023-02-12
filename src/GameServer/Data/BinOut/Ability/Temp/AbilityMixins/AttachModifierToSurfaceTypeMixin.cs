using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierToSurfaceTypeMixin : ConfigAbilityMixin
{
	public SceneSurfaceType surfaceType;
	public ModifierWithPredicates[] modifiersWithPredicates;
	public string extraEnterTriggerLevelAbility;
	public string extraExitTriggerLevelAbility;
	public string extraResetTriggerLevelAbility;

	public class ModifierWithPredicates
	{
		public string modifierName;
		public ConfigAbilityPredicate[] predicates;
		public bool attachModifier;
	}
}
