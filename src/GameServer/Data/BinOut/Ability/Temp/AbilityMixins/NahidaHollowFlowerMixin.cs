using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class NahidaHollowFlowerMixin : ConfigAbilityMixin
{
	public string effectPattern;
	public string effectTrigger;
	public double interval;
	public int maxCount;
	public int createMaxNumPerInterval;
	public object createOffset;
	public float maxRange;
	public float destroyRange;
}
