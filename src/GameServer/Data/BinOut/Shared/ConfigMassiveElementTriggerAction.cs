using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMassiveElementTriggerAction
{
	public MassiveElementTriggerType triggerType;
	public ModifierStacking stackType;
	public float reduceDurability;
	public float duration;
	public string attackID;
	public string actionID;
	public ConfigAbilityAction[] onFlush;
	public ConfigAbilityAction[] onPreUpdate;
	public ConfigAbilityAction[] onDetach;
}