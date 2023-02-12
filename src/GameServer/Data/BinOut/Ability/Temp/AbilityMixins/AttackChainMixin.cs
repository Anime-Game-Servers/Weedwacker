using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttackChainMixin : ConfigAbilityMixin
{
	public object? cd;
	public ElementReactionType[] reactionTypes;
	public string[] attackTags;
	public string effectName;
	public string effectAttachPoint;
	public float lineRange;
	public string attackChainReceiverKey;
}
