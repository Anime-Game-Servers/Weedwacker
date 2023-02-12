using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TurnDirectionToPos : ConfigAbilityAction
{
	public ConfigBornType toPos;
	public float minAngle;
	public float maxAngle;
}
