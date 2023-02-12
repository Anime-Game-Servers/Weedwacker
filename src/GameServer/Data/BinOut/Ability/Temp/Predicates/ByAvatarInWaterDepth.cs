using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByAvatarInWaterDepth : ConfigAbilityPredicate
{
	public RelationType compareType;
	public float depth;
}
