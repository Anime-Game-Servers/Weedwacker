using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class TriggerWitchTimeMixin : ConfigAbilityMixin
{
	public TargetType ignoreTargetType;
	public float timescale;
	public float duration;
	public bool useMax;
	public bool enableEffect;
	public bool enableDelay;
	public float delayTimeScale;
	public float delayDuration;
	public string openEffectPattern;
	public string closeEffectPattern;
	public string weatherPattern;
}
