using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfCombinedItem : ConfigPerfItemBase
{
	public Dictionary<string, ConfigPerfCombineItemOptionArrayInfo> itemOptionMap;
}