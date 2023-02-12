using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetSpecialCamera : ConfigAbilityAction
{
	public bool enable;
	public string specialCameraName;
}
