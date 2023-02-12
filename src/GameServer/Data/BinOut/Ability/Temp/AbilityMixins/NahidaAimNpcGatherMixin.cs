using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class NahidaAimNpcGatherMixin : ConfigAbilityMixin
{
	public string npcAttachEffect;
	public string gatherAttachEffect;
	public float detectRangeForNPC;
	public float widthForNPC;
	public float heightForNPC;
	public float detectRangeForGather;
	public float widthForGather;
	public float heightForGather;
	public int gatherMaxCount;
}
