using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByDamageReceivedMixin : ConfigAbilityMixin
{
	public DoActionByDamageReceivedParamType paramType;
	public object valueMin;
	public object valueMax;
	public ConfigAbilityAction[] actionQueue;
}
