using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierToSelfGlobalValueNoInitMixin : ConfigAbilityMixin
{
	public string globalValueKey;
	public AddActionType addAction;
	public object[] valueSteps;
	public string[] modifierNameSteps;
	public ConfigAbilityAction[][] actionQueues;
	public bool removeAppliedModifier;
}
