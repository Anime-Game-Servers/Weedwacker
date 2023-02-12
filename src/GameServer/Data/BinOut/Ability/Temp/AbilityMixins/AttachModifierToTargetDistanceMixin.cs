using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierToTargetDistanceMixin : ConfigAbilityMixin
{
	public uint[] targetIDs;
	public bool byserver;
	public object[] valueSteps;
	public string[] modifierNameSteps;
	public bool removeAppliedModifier;
	public string BlendParam;
	public object[] BlendDistance;
	public string effectPattern;
}
