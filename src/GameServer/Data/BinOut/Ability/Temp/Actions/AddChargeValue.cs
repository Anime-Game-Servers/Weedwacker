using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AddChargeValue : ConfigAbilityAction
{
	public ElementType chargeType;
	public object value;
	public string globalValueKey;
}