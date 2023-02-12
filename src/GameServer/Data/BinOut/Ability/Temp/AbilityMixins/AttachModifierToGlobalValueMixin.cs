using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierToGlobalValueMixin : ConfigAbilityMixin
{
	public AbilityTargetting globalValueTarget;
	public SelectTargets otherTargets;
	public string globalValueKey;
	public object[] valueSteps;
	public string[] modifierNameSteps;
	public ConfigAbilityAction[][] actionQueues;
	public bool removeAppliedModifier;
	public bool removeAppliedModifierTargetDisappear;
	public bool removeAppliedModifierClearGlobalValue;
	public bool removeModifierByAttach;
	public TargetRegisterType targetRegisterType;
	public bool notRemoveModifierWhenEntityNotSync;
}
