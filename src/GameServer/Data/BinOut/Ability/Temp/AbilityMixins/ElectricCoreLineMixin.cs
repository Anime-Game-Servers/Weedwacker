using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ElectricCoreLineMixin : ConfigAbilityMixin
{
	public SelectTargets otherTargets;
	public string activateSkillKey;
	public ConfigAbilityPredicate[] predicates;
}
