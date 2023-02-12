using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfGradeItem : ConfigPerfItemBase
{
	public Dictionary<string, int> deviceSpecItem;
	public Dictionary<string, ConfigPerfGradeItemOptionArrayInfo> itemOptionMap;
	public Dictionary<string, ConfigPerfGradeItemOverrideInfo> overrideMap;
}