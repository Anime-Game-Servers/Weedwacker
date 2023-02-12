
namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AddLogicStateValue : ConfigAbilityAction
{
	public string logicStateName;
	public object value;
	public bool useLimitRange;
	public object maxValue;
	public object minValue;
}