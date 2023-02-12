using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachActionToModifierMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] onAdded;
	public ConfigAbilityAction[] onRemoved;
}
