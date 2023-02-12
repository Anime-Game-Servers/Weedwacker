using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetChargeRatio : ConfigAbilityAction
{
	public ElementType chargeType;
	public object ratio;
	public string globalValueKey;
}