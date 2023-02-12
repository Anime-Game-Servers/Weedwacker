using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class HitLevelGaugeMixin : ConfigAbilityMixin
{
	public HitLevel fromHitLevel;
	public HitLevel toHitLevel;
	public float maxCharge;
	public float minChargeDelta;
	public float maxChargeDelta;
	public float fadeTime;
}