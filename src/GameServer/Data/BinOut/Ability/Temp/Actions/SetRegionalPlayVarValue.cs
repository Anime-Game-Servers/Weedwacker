using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetRegionalPlayVarValue : ConfigAbilityAction
{
	public RegionalPlayVarType varType;
	public float varValue;
}
