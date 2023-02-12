using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetAIParam : ConfigAbilityAction
{
	public object param;
	public object value;
	public bool isBool;
	public ParamLogicType logicType;
}