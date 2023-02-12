using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AvatarLockForwardFlyMixin : ConfigAbilityMixin
{
	public Vector worldForward;
	public float flySpeedScale;
	public float flyBackSpeedScale;
	public Vector eularRawInput;
}
