using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigHomeworldFurnitureSet
{
	public float radius;
	public float height;
	public ConfigHomeworldFurnitureUnit[] furnitureUnits;
	public ConfigHomeworldSuiteNpcSpawnPoint[] npcSpawnPoints;

	public class ConfigHomeworldFurnitureUnit
	{
		public uint furnitureID;
		public Vector position;
		public Vector rotation;
		public int parentIndex;
	}
	public class ConfigHomeworldSuiteNpcSpawnPoint
	{
		public Vector position;
		public Vector rotation;
	}
}