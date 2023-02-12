using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class DoTileActionManagerMixin : ConfigAbilityMixin
{
	public float duration;
	public string actionID;
	public string actionPosKey;
	public string actionRadiusKey;
	public bool reactionForceUseOwnerProp;
	public ConfigAbilityAction[] actions;
}
