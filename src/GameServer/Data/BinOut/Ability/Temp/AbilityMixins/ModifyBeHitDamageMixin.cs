using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ModifyBeHitDamageMixin : ConfigAbilityMixin
{
	public string Actor_ElementReactionCriticalDelta;
	public bool ignoreEventInfo;
	public ByAny[] predicates;
}
