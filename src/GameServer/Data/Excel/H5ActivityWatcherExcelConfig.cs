using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class H5ActivityWatcherExcelConfig : WatcherConfig
{
	public uint h5ActivityId;
	public LogicType condComb;
	public H5ActivityCondConfig[] condList;
	public bool isDailyRefresh;
}