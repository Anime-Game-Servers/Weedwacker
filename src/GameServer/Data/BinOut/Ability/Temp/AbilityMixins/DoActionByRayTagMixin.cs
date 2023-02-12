using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoActionByRayTagMixin : ConfigAbilityMixin
{
	public UGCRayTriggerDirectionType[] UGCRayTriggerDirections;
	public uint[] rayTags;
	public string[] modifierToTags;
	public float raycastInterval;
}
