using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGlobalAI
{
	public float avatarMeleeSlotRadius;
	public float avoidanceRadius;
	public float avoidanceForce;
	public float lod0;
	public float lod1;
	public float lod2;
	public uint[] sensingIgnoreCampIDs;
	public Dictionary<string, ConfigPublicAISkillCD> publicCDs;
	public Dictionary<ConfigWeatherType, NeuronName[]> defaultWeatherNeuronMapping;
	public bool useServerPathfinding;

	public class ConfigPublicAISkillCD
	{
		public string name;
		public float minInterval;
	}
}