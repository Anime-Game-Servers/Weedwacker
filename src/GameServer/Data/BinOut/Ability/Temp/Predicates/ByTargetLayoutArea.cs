using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetLayoutArea : ConfigAbilityPredicate
{
	public JsonClimateType areaType;
	public JsonClimateType climateType;
	public uint areaID;
}
