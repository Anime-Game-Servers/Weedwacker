using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigHomeBlock
{
	public uint blockId;
	public ConfigHomeFurniture[] persistentFurnitureList;
	public ConfigHomeFurniture[] deployFurniureList;
	public ConfigHomeFurnitureSuite[] furnitureSuiteList;
	public ConfigHomeAnimal[] deployAnimalList;
	public ConfigWeekendDjinn[] weekendDjinnInfoList;
}