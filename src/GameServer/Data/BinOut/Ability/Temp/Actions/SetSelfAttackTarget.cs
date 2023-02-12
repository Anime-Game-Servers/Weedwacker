using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetSelfAttackTarget : ConfigAbilityAction
{
	public bool turnToTargetImmediately;
	public bool turnToTargetKeepUpAxisDirection;
}
