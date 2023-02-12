using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AnimatorRotationCompensateMixin : ConfigAbilityMixin
{
	public string[] animatorStateIDs;
	public float animationRotate;
	public float angleLimit;
}
