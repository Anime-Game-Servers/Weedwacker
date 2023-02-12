using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class TriggerPostProcessEffectMixin : ConfigAbilityMixin
{
	public string postEffectAssetName;
	public float duration;
	public bool isStageEffect;
}
