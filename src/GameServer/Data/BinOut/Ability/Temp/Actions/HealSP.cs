using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class HealSP : ConfigAbilityAction
{
	public object amount;
	public object amountByCasterMaxSPRatio;
	public object amountByTargetMaxSPRatio;
	public object amountByCurrentComboRatio;
	public bool muteHealEffect;
	public float healRatio;
}