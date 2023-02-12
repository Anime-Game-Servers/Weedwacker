using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByPoseIDMixin : ConfigAbilityMixin
{
	public int[] poseIDs;
	public ConfigAbilityPredicate[] enterPredicates;
	public ConfigAbilityPredicate[] exitPredicates;
	public ConfigAbilityAction[] enterActions;
	public ConfigAbilityAction[] exitActions;
}
