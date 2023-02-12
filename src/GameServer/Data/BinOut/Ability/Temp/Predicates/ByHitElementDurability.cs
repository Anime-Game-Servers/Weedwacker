using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByHitElementDurability : ConfigAbilityPredicate
{
	public ElementType element;
	public float durability;
	public RelationType compareType;
	public bool applyAttenuation;
}
