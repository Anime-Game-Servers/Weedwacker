using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AvatarEnterViewBias : ConfigAbilityAction
{
	public float sphereBiasPole;
	public float sphereBiasElev;
	public float sphereRadius;
	public float postForwardPoleDeltaAngle;
	public float postForwardElevDeltaAngle;
	public float durationInNormalState;
	public bool lockZoom;
	public bool lockResetBack;
}
