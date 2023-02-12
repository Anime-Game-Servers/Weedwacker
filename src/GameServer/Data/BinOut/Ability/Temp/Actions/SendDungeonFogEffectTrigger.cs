using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SendDungeonFogEffectTrigger : ConfigAbilityAction
{
	public string parameter;
	public string cameraFogEffectName;
}
