using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class EnvAnimalWeightExcelConfig
{
	public EnvironmentType envType;
	public EnvironmentWeightType[] weightVec;

	public class EnvironmentWeightType
	{
		public uint animalId;
		public EntityType entityType;
		public uint weight;
		public Dictionary<uint, uint> aliveHourMap;
	}
}