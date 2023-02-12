using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DigAttachModifierToTargetDistanceMixin : ConfigAbilityMixin
{
	public uint targetID;
	public float distance;
	public string unfoundEffectPattern;
	public string foundEffectPattern;
	public ConfigAbilityAction[] unfoundActionArray;
	public ConfigAbilityAction[] foundActionArray;
}
