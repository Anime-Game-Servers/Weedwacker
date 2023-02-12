using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ModifyDamageMixin : ConfigAbilityMixin
{
	public string[] animEventNames;
	public string[] attackTags;
	public AttackType attackType;
	public bool ignoreEventInfo;
	public object damagePercentage;
	public object damagePercentageRatio;
	public object damageExtra;
	public object bonusCritical;
	public object bonusCriticalHurt;
	public ElementTypeModifier elementTypeModifier;
	public ConfigAbilityPredicate[] predicates;
	public bool trueDamage;
	public object defenseIgnoreRatio;
	public object defenseIgnoreDelta;

	public class ElementTypeModifier
	{
		public ElementType elementType;
	}
}
