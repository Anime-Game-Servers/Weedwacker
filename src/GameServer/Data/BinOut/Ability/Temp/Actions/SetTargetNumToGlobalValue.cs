using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetTargetNumToGlobalValue : ConfigAbilityAction
{
	public AbilityTargetting srcTarget;
	public SelectTargets srcOtherTargets;
	public ConfigAbilityPredicate[] srcPredicates;
	public AbilityTargetting dstTarget;
	public SelectTargets dstOtherTargets;
	public ConfigAbilityPredicate[] dstPredicates;
	public string key;
	public bool useLimitRange;
	public object maxValue;
	public object minValue;
}
