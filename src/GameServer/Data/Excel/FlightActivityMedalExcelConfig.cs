using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FlightActivityMedalExcelConfig
{
	public uint id;
	public string medal_icon;
	public FlightDailyInfo[] daily_info;

	public class FlightDailyInfo
	{
		public uint watcher;
	}
}