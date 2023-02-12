using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByHasLevelTag : ConfigAbilityPredicate
{
	public string levelTag;
	public uint levelTagId;
}
