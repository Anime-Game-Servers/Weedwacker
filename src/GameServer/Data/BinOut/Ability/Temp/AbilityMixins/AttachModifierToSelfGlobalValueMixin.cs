using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierToSelfGlobalValueMixin : ConfigAbilityMixin
{
	public AbilityTargetting globalValueTarget;
	public string globalValueKey;
	public AddActionType addAction;
	public object defaultGlobalValueOnCreate;
	public object[] valueSteps;
	public object modifierNameSteps; //string or string[]
	public ConfigAbilityAction[][] actionQueues;
	public bool removeAppliedModifier;
}
