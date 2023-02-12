using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByElementTriggerEntityType : ConfigAbilityPredicate
{
	public EntityType[] entityTypes;
	public bool forcebyOriginOwner;
}
