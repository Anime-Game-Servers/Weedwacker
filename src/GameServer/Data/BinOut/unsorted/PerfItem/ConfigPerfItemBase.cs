using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfItemBase
{
	public Dictionary<PerfRatingCategory, int[]> categoryRatingMap;
	public PlayerCustomOptionSetting playerCustomOption;
}