using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ChargeBarMixin : ConfigAbilityMixin
{
	public ElementType chargeBarElementType;
	public int chargeBarIconID;
	public object initialValue;
	public object maxValue;
}
