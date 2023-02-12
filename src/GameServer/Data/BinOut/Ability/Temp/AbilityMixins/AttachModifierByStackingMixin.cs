using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierByStackingMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] actionQueue;
	public string stackingModifier;
}