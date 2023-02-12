using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfNumberArrayItem : ConfigPerfItemBase
{
	public Dictionary<string, float[]> deviceSpecItem;
	public Dictionary<string, ConfigPerfNumberArrayItemOptionArrayInfo> itemOptionMap;
	public Dictionary<string, ConfigPerfNumberArrayItemOverrideInfo> overrideMap;
}