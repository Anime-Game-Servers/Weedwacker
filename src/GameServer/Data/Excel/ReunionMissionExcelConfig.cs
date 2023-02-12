using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ReunionMissionExcelConfig
{
	public uint id;
	public uint watcherGroupId;
	public uint targetScore;
	public uint finishRewardId;
	public uint[] targetScoreList;
	public uint[] finishRewardIdList;
	public uint[] showRewardIdList;
}