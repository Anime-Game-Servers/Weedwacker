using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ChangeFollowDampTime : ConfigAbilityAction
{
	public object effectPattern;
	public object PositionDampTime;
	public object RotationDampTime;
}
