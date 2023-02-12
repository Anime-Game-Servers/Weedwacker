using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class CountCheckEventMixin : ConfigAbilityMixin
{
	public string eventKey;
	public float checkTime;
	public int checkCount;
	public ConfigAbilityAction[] actionQueue;
}
