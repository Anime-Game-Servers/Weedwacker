using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AvatarEnterCameraShot : ConfigAbilityAction
{
	public string cameraMoveCfgPath;
	public AbilityCameraShotType shotType;
}
