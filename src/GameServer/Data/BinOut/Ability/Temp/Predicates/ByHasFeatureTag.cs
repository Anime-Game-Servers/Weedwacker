using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByHasFeatureTag : ConfigAbilityPredicate
{
	public uint[] featureTagIDs;
}
