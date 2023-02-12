using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class RushMove : ConfigAbilityAction
{
	public ConfigBornType toPos;
	public float minRange;
	public float maxRange;
	public float timeRange;
}
