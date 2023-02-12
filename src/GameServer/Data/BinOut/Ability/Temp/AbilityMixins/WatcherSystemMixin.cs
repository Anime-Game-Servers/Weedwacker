using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class WatcherSystemMixin : ConfigAbilityMixin
{
	public uint watcherId;
	public WatcherSystemMixinType mixinType;
	public WatcherSystemListenType listenEntityType;
	public string listenStateId;
	public ConfigAbilityPredicate[] predicates;
}
