using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class VelocityForceMixin : ConfigAbilityMixin
{
	public bool muteAll;
	public bool useAll;
	public VelocityForceType[] includeForces;
	public VelocityForceType[] excludeForces;
}
