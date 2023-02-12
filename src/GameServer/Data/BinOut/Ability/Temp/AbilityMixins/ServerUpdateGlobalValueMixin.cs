using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ServerUpdateGlobalValueMixin : ConfigAbilityMixin
{
	public string key;
	public bool useLimitRange;
	public object maxValue;
	public object minValue;
}
