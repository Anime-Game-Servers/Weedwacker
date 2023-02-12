using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfBoolItem : ConfigPerfItemBase
{
	public Dictionary<string, bool> deviceSpecItem;
	public Dictionary<string, ConfigPerfBoolItemOptionArrayInfo> itemOptionMap;
	public Dictionary<string, ConfigPerfBoolItemOverrideInfo> overrideMap;
}