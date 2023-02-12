using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachModifierByActivityGachaStageMixin : ConfigAbilityMixin
{
	public uint[] stageIDs;
	public string[] modifierNameSteps;
}
