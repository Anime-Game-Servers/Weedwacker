using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierToHPPercentMixin : ConfigAbilityMixin
{
	public object[] valueSteps;
	public string[] modifierNameSteps;
}
