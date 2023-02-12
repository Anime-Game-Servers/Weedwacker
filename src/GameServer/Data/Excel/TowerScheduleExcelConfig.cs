using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class TowerScheduleExcelConfig
{
	public uint scheduleId;
	public uint[] entranceFloorId;
	public TowerSchedule[] schedules;
	public string closeTime;
	public uint rewardGroup;
	public TowerStarReward[] scheduleRewards;
	public uint commemorativeReward;
	public uint monthlyLevelConfigId;
	public uint descTextMapHash;
	public uint buffnameTextMapHash;
	public string icon;

	public class TowerSchedule
	{
		public uint[] floorList;
		public string openTime;
	}
	public class TowerStarReward
	{
		public uint minStarCount;
		public uint rewardId;
	}
}