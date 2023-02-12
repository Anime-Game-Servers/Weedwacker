using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("EnvAnimalGatherExcelConfigData.json")]
public class EnvAnimalGatherData
{
	public uint animalId;
	public EntityType entityType;
	public IdCountConfig[] gatherItemList;
	public uint escapeRadius;
	public uint escapeTime;
	public uint aliveTime;
	public string excludeWeathers;
}
