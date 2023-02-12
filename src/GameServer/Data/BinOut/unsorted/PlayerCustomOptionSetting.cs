using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class PlayerCustomOptionSetting
{
	public GraphicsSettingEntryType settingEntry;
	public Dictionary<string, PlayerCustomOptionConfig> customConfigMap;
	public PerfOptionTextType optionNameType;
	public ConfigGraphicSettingEntrySortType sortType;
}