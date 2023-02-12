using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TryFindBlinkPoint : ConfigAbilityAction
{
	public float forwardAngle;
	public float minRange;
	public float maxRange;
	public float limitY;
	public bool ignoreWater;
	public bool checkInCamera;
}
