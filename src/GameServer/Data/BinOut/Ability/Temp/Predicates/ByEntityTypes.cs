using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByEntityTypes : ConfigAbilityPredicate
{
	public EntityType[] entityTypes;
	public bool reject;
	public bool useEventSource;
	public short isAuthority;
}
