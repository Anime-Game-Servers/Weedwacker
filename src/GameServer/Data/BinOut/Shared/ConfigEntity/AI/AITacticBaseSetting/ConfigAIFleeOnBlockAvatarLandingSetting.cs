
namespace Weedwacker.GameServer.Data;

public class ConfigAIFleeOnBlockAvatarLandingSetting : ConfigAITacticBaseSetting
{
	public ConfigAIFleeOnBlockAvatarLandingData defaultSetting;
	public Dictionary<int, ConfigAIFleeOnBlockAvatarLandingData> specification;

	public class ConfigAIFleeOnBlockAvatarLandingData
	{
		public int speedLevel;
		public float turnSpeedOverride;
		public float triggerDistance;
		public float fleeAngle;
		public float fleeDistanceMin;
		public float fleeDistanceMax;
		public float neuronTriggerCD;
	}
}