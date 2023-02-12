using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfStringKeyItem : ConfigPerfItemBase
{
	public Dictionary<string, string> deviceSpecItem;
	public Dictionary<string, ConfigPerfStringKeyItemOptionArrayInfo> itemOptionMap;
	public Dictionary<string, ConfigPerfStringKeyItemOverrideInfo> overrideMap;
}