using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class FireHitEffect : ConfigAbilityAction
{
	public string hitEntity;
	public ConfigHitScene hitScene;
}
