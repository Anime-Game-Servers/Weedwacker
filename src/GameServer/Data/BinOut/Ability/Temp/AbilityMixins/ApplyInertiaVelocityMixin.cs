using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ApplyInertiaVelocityMixin : ConfigAbilityMixin
{
	public float damping;
	public bool useXZ;
	public bool useY;
}
