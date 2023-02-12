using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AddChargeBarValue : ConfigAbilityAction
{
	public object value;
	public bool randomInRange;
	public object maxValue;
	public object minValue;
}
