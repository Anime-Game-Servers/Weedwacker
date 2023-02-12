using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetInArea : ConfigAbilityPredicate
{
	public TargetPositionAreaLevel areaLevel;
	public uint[] areas;
}
