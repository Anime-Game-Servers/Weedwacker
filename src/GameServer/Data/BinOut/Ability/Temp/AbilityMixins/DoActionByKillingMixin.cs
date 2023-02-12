using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByKillingMixin : ConfigAbilityMixin
{
	public string[] attackTags;
	public float detectWindow;
	public ConfigAbilityAction[] onKill;
}
