using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class FireEffectToTarget : ConfigAbilityAction
{
	public object effectPattern;
	public bool reverse;
	public bool fromSelf;
	public float scale;
}