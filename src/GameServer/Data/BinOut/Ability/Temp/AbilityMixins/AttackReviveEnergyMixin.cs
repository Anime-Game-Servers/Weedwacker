using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttackReviveEnergyMixin : ConfigAbilityMixin
{
	public string[] attackTags;
	public float maxValue;
	public float minValue;
	public float addValue;
	public ConfigAbilityAction reviveAction;
	public Dictionary<ElementType, ConfigAbilityAction> fireEffectActions;
}
