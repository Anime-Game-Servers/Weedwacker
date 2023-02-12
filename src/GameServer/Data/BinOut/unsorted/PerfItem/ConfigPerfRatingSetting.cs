using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfRatingSetting
{
	public Dictionary<PerfRatingCategory, ConfigPerfRatingLevel[]> perfRating;
	public Dictionary<PerfRatingCategory, PerfRatingCategory> perfRatingCopyMap;
	public Dictionary<PerfRatingCategory, int> perfRatingDefault;
}