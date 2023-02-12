using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class CostStaminaMixin : ConfigAbilityMixin
{
	public object costStaminaDelta;
	public object costStaminaRatio;
	public ConfigAbilityAction[] onStaminaEmpty;
}
