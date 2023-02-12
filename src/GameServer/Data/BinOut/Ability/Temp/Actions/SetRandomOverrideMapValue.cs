using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetRandomOverrideMapValue : ConfigAbilityAction
{
	public float valueRangeMax;
	public float valueRangeMin;
	public string overrideMapKey;
	public RoundRandomType roundType;
}
