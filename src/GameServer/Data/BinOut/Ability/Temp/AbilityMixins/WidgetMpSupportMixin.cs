using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class WidgetMpSupportMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] succActions;
	public ConfigAbilityAction[] failActions;
	public ConfigAbilityPredicate[] predicates;
}
