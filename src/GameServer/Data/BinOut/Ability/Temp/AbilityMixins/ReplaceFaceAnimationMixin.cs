using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ReplaceFaceAnimationMixin : ConfigAbilityMixin
{
	public string[] oldFaceAnimations;
	public string[] newFaceAnimations;
}
