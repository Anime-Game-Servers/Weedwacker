using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigHomeworldDefaultSave
{
	public uint sceneID;
	public ConfigHomeworldBlockDefaultSave[] blockArrangementInfoList;
	public bool isSetBornPos;
	public Vector bornPos;
	public Vector bornRot;
	public ConfigHomeworldFurnitureDefaultSave[] doorList;
	public ConfigHomeworldFurnitureDefaultSave[] stairList;
	public ConfigHomeworldFurnitureDefaultSave mainHouse;
	public uint comfortValue;
	public Vector djinnPos;
	public uint tmpVersion;

	public class ConfigHomeworldBlockDefaultSave
	{
		public int blockId;
		public ConfigHomeworldFurnitureDefaultSave[] persistentFurnitureList;
		public ConfigHomeworldFurnitureDefaultSave[] deployFurniureList;
		public uint[] deployNpcList;
		public uint[] furnitureSuiteList;
		public uint[] deployAnimalList;
		public bool isUnlocked;
		public uint comfortValue;
		public ConfigHomeworldDjinnInfoDefaultSave[] weekendDjinnInfoList;
		public uint[] dotPatternList;

		public class ConfigHomeworldDjinnInfoDefaultSave
		{
			public Vector pos;
			public Vector rot;
		}
	}
	public class ConfigHomeworldFurnitureDefaultSave
	{
		public uint furnitureId;
		public Vector spawnPos;
		public Vector spawnRot;
		public int parentFurnitureIndex;
	}
}