using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetForwardAndSelfPosition : ConfigAbilityPredicate
{
	public object value;
	public bool isXZ;
}
