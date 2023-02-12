using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ChangeLockTypeMixin : ConfigAbilityMixin
{
	public string lockType;
	public float overrideRange;
	public float overrideNormalPri;
	public float overrideCombatPri;
}
