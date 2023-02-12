using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionBySelfElementReactionMixin : ConfigAbilityMixin
{
	public ElementReactionType[] reactionTypes;
	public ConfigAbilityAction[] actionQueue;
}
