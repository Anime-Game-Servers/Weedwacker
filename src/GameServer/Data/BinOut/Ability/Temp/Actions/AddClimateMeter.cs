using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AddClimateMeter : ConfigAbilityAction
{
	public JsonClimateType climateType;
	public object value;
}
