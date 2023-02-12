using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ClampDamageReceivedMixin : ConfigAbilityMixin
{
	public DamageClampType clampType;
	public object maxValue;
	public object minValue;
}
