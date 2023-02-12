using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class DungeonFogEffects : ConfigAbilityAction
{
	public bool enable;
	public string cameraFogEffectName;
	public string playerFogEffectName;
	public Vector localOffset;
}