using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AttachEffectFirework : ConfigAbilityAction
{
	public object effectPattern;
	public ConfigBornType born;
	public float scale;
}
