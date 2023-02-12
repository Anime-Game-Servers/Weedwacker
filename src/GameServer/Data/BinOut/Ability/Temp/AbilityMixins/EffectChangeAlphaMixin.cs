using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class EffectChangeAlphaMixin : ConfigAbilityMixin
{
	public AbilityTargetting target;
	public SelectTargets otherTargets;
	public ConfigAbilityPredicate[] predicates;
	public float startDuration;
	public float endDuration;
}
