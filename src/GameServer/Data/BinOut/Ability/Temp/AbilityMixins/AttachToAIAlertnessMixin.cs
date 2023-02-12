using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachToAIAlertnessMixin : ConfigAbilityMixin
{
	public int[] alertness;
	public string modifierName;
}
