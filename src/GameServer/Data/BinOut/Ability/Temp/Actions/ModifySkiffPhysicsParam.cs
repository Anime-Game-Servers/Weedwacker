using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ModifySkiffPhysicsParam : ConfigAbilityAction
{
	public float angularVelocityClamp;
	public float disableMinSpeed;
	public float angularVelocityClampFadeTime;
}