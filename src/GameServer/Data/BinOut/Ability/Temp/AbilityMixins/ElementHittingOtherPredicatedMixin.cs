using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ElementHittingOtherPredicatedMixin : ConfigAbilityMixin
{
	public ConfigAbilityPredicate[] prePredicates;
	public ElementBatchPredicated[] elementBatchPredicateds;

	public class ElementBatchPredicated
	{
		public ElementType[] elementTypeArr;
		public ConfigAbilityAction[] successActions;
		public ConfigAbilityAction[] failActions;
	}
}
