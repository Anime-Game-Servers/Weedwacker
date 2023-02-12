using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DamageStatisticsMixin : ConfigAbilityMixin
{
	public bool isMinDamage;
	public string damageElementTypeKey;
	public string damageAmountKey;
	public ConfigAbilityAction[] onExitActions;
}