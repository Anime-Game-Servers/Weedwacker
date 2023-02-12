using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class GlobalSubShieldMixin : ConfigAbilityMixin
{
	public string mainShieldModifierName;
	public bool notifyMainshieldWhenHit;
}
