using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes;

public class ConfigBornByActionPoint : ConfigBornType
{
	public ActionPointType actionPointType;
	public ConfigActionPointSelectType selectType;
}
