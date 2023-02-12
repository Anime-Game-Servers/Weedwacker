using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByEventMixin : ConfigAbilityMixin
{
	public AvatarStageType type;
	public OnEventType onEvent;
	public uint[] pickItemConfigIDs;
	public uint skillReadyID;
	public ConfigAbilityPredicate[] predicates;
	public ConfigAbilityAction[] actions;
	public ConfigAbilityStateToActions[] onAbilityStateAdded;
	public ConfigAbilityStateToActions[] onAbilityStateRemoved;
	public string costEnergyDeltaName;
}