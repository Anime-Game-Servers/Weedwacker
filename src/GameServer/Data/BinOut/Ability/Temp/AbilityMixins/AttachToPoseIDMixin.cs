using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachToPoseIDMixin : ConfigAbilityMixin
{
	public int[] poseIDs;
	public string modifierName;
}
