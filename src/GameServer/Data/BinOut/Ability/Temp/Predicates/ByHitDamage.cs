using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByHitDamage : ConfigAbilityPredicate
{
	public object damage;
	public bool useOriginDamage;
}
