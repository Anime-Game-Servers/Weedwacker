using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

internal class GrapplingHookRushMove : ConfigAbilityAction
{
	//guessed types
	public ConfigBornType toPos;
	public float speed;
	public float accSpeed;
	public float maxSpeed;
	public string[] animatorStateIDs;
	public bool isInAir;
}
