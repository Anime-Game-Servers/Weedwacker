using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BattlePassRewardExcelConfig
{
	public uint indexId;
	public uint level;
	public uint[] freeRewardIdList;
	public uint[] paidRewardIdList;
	public bool showUp;
}