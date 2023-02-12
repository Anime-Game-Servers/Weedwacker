using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ServerFinishWatcherMixin : ConfigAbilityMixin
{
	public uint watcherId;
	public ConfigAbilityPredicate[] predicates;
}
