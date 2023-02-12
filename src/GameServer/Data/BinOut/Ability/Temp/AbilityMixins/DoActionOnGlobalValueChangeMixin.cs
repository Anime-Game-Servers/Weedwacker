using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionOnGlobalValueChangeMixin : ConfigAbilityMixin
{
	public string globalValueKey;
	public ConfigAbilityAction[] actions;
	public bool isDelay;
	public float delayTime;
}
