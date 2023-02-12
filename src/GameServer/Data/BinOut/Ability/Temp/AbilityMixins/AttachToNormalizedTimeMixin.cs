using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachToNormalizedTimeMixin : ConfigAbilityMixin
{
	public string stateID;
	public string modifierName;
	public AbilityTargetting target;
	public ConfigAbilityPredicate[] predicates;
	public float normalizeStart;
	public float normalizeEnd;
}
