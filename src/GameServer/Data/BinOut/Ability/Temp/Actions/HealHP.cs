using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class HealHP : ConfigAbilityAction
{
	public object amount;
	public object amountByCasterMaxHPRatio;
	public object amountByTargetMaxHPRatio;
	public object amountByTargetCurrentHPRatio;
	public object amountByCasterAttackRatio;
	public bool muteHealEffect;
	public float healRatio;
	public bool ignoreAbilityProperty;
}
