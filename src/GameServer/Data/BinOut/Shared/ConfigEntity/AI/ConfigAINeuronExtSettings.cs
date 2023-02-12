using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAINeuronExtSettings
{
	public ConfigAINeuronHitBuddySetting HIT_BUDDY;

	public class ConfigAINeuronHitBuddySetting
	{
		public float feelRange;
		public ConcernType responserConcernType;
		public TargetType responserCampType;
		public ConcernType triggerResponserConcernType;
		public TargetType triggerResponserCampType;
		public float reserveTime;
	}
}