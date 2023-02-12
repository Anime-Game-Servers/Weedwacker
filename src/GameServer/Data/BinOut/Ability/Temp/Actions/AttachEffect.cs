using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AttachEffect : ConfigAbilityAction
{
	public object effectPattern;
	public ConfigBornType born;
	public float scale;
	public object effectTempleteID;
	public bool setSelfAsEffectPluginTarget;
}
