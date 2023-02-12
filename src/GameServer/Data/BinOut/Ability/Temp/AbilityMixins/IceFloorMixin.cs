using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class IceFloorMixin : ConfigAbilityMixin
{
	public float width;
	public float height;
	public float moveDistance;
	public float minInterval;
	public ConfigAbilityAction doAction;
}
