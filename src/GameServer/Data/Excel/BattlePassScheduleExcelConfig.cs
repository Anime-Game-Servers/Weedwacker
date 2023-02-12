using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BattlePassScheduleExcelConfig
{
	public uint id;
	public uint titleNameTextMapHash;
	public string beginDateStr;
	public string endDateStr;
	public uint[] cycleList;
	public uint extraPaidRewardId;
	public uint extraPaidAddPoint;
	public uint buyLevelCostCoinNum;
	public uint cyclePointUpperLimit;
	public uint levelRewardIndexId;
	public uint[] normalRewardList;
	public BattlePassScheduleRewardType rewardType;
	public string showImage;
	public uint[] showRewardList;
	public uint[] stroyRewardList;
	public uint storyId;
	public uint mailDayCount;
	public uint mailConfigId;
}