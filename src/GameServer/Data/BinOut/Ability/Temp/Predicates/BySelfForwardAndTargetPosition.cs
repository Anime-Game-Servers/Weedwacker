using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class BySelfForwardAndTargetPosition : ConfigAbilityPredicate
{
	public object value;
	public bool isXZ;
}
