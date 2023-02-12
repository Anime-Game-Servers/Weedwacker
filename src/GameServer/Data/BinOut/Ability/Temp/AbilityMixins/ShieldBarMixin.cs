using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ShieldBarMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] onShieldBroken;
	public bool revert;
	public string showDamageText;
	public bool useMutiPlayerFixData;
}
