using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class RecycleModifierMixin : ConfigAbilityMixin
{
	public string modifierName;
	public float cd;
	public float initialCD;
}