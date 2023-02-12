using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class BeingHitMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] toAttacker;
	public ConfigAbilityAction[] toAttackerOwner;
	public ConfigAbilityAction[] toAttackerOriginOwner;
}