using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class BySceneSurfaceType : ConfigAbilityPredicate
{
	public SceneSurfaceType[] filters;
	public bool include;
	public Vector offset;
}
