using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByTeamStatusMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] actions;
	public ConfigAbilityPredicate[] predicates;
	public float waitTime;
	public bool waitForBigteam;
	public bool runPostRecover;
}
