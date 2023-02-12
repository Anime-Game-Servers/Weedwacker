using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SendEffectTriggerToLineEffect : ConfigAbilityAction
{
	public string parameter;
	public AnimatorParamType type;
	public int value;
	public object effectPattern;
	public float floatValue;
}
