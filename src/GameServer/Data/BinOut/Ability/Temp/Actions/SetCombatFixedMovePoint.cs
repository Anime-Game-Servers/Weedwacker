using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetCombatFixedMovePoint : ConfigAbilityAction
{
	public bool setPoint;
	public ConfigBornType toPos;
}
