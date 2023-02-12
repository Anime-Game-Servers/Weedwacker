using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ElementReactionShockMixin : ConfigAbilityMixin
{
	public float thinkInterval;
	public string campGlobalKey;
	public ConfigAbilityAction attackAction;
	public ConfigAbilityAction conductAction;
}
