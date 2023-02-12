using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ElementAdjustMixin : ConfigAbilityMixin
{
	public float changeInterval;
	public Dictionary<ElementType, string> elementModifies;
}