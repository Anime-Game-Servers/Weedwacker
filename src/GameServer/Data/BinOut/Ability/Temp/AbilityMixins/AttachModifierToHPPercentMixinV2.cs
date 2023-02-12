using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierToHPPercentMixinV2 : ConfigAbilityMixin
{
	public object[] valueSteps;
	public string[] modifierNameSteps;
	public uint delayFrameCount;
	public bool isNeedFlushOnRemoved;
}
