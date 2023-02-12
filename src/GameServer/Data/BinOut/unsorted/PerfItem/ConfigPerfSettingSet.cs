using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfSettingSet
{
	public Dictionary<string, ConfigPerfNumberItem> numberItems;
	public Dictionary<string, ConfigPerfNumberArrayItem> numberArrayItems;
	public Dictionary<string, ConfigPerfStringKeyItem> stringKeyItems;
	public Dictionary<string, ConfigPerfGradeItem> gradeItems;
	public Dictionary<string, ConfigPerfBoolItem> boolItems;
	public Dictionary<string, ConfigPerfCombinedItem> combinedItems;
}