using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class GadgetChargeMixin : ConfigAbilityMixin
{
	public ElementType chargeType;
	public float chargeRatio;
	public float chargeValue;
	public float maxChargeValue;
	public object[] valueSteps;
	public string[] modifierNameSteps;
	public string globalValueKey;
	public string ratioGlobalValueKey;
}
