using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfNumberItem : ConfigPerfItemBase
{
	public Dictionary<string, float> deviceSpecItem;
	public Dictionary<string, ConfigPerfNumberItemOptionArrayInfo> itemOptionMap;
	public Dictionary<string, ConfigPerfNumberItemOverrideInfo> overrideMap;
}