using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class OnLocalAvatarAddedShieldMixin : ConfigAbilityMixin
{
	public HasShieldType[] shieldTypeList;
	public ConfigAbilityAction[] actions;
}