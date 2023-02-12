using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByHitBoxName : ConfigAbilityPredicate
{
	public string[] hitBoxNames;
}
