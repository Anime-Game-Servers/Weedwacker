using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachToStateIDMixin : ConfigAbilityMixin
{
	public string[] stateIDs;
	public string modifierName;
	public AbilityTargetting target;
	public ConfigAbilityPredicate[] predicates;
	public bool isCheckOnAttach;
}
