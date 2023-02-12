using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class EntityInVisibleMixin : ConfigAbilityMixin
{
	public ConfigAbilityPredicate[] predicates;
	public AbilityEntityVisibleReason reason;
	public bool disableAudio;
}
