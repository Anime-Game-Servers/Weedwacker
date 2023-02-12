using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class FireEffect : ConfigAbilityAction
{
	public object effectPattern;
	public string[] othereffectPatterns;
	public ConfigBornType born;
	public bool ownedByLevel;
	public bool useY;
	public float scale;
	public object effectTempleteID;
	public bool setSelfAsEffectPluginTarget;
	public bool useRemoteSelfPos;
}
