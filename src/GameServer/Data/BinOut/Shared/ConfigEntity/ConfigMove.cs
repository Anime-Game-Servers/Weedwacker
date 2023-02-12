using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigMove
{
	public ConfigMoveVelocityForce velocityForce;
	public bool handleCombatTaskImmediately;

	public class ConfigMoveVelocityForce
	{
		public bool muteAll;
		public bool useAll;
		public VelocityForceType[] includeForces;
		public VelocityForceType[] excludeForces;
	}
}
