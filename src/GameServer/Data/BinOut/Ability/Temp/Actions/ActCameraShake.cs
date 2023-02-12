using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ActCameraShake : ConfigAbilityAction
{
	public ConfigCameraShake cameraShake;
	public ConfigBornType born;
}
