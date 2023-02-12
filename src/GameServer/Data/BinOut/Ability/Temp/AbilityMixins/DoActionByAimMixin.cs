using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByAimMixin : ConfigAbilityMixin
{
	public EntityType[] entityTypes;
	public float cd;
	public string colliderNodeName;
	public ConfigAbilityAction[] actionQueue;
	public ConfigAbilityPredicate[] predicates;
	public ConfigAbilityAction[] onRemoveActionQueue;
}
