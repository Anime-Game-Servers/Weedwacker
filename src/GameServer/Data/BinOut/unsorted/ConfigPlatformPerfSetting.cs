using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPlatformPerfSetting
{
	public ConfigPerfRatingSetting perfRating;
	public ConfigPerfSettingSet perfOptions;
	public string[] playerCustomOptions;
	public bool applyGlobalPerfForGraphicSetting;
	public Dictionary<PerfCostRatioGrade, float> costRatioGrade;
}