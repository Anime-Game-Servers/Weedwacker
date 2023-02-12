using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class GlobalMainShieldMixin : ConfigAbilityMixin
{
	public string shieldType;
	public object shieldAngle;
	public object shieldHPRatio;
	public object shieldHP;
	public string costShieldRatioName;
	public string showDamageText;
	public ConfigAbilityAction[] onShieldBroken;
	public object amountByGetDamage;
	public string effectPattern;
	public string childShieldModifierName;
	public bool targetMuteHitEffect;
	public bool infiniteShield;
	public object healLimitedByCasterMaxHPRatio;
	public object healLimitedByLocalCreatureMaxHPRatio;
}
