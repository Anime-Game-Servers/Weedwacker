using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByElementReactionMixin : ConfigAbilityMixin
{
	public float range;
	public EntityType[] entityTypes;
	public ElementReactionType[] reactionTypes;
	public ConfigAbilityAction[] actions;
}
