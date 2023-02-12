using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FleurFairDungeonExcelConfig
{
	public uint id;
	public uint sectionId;
	public uint openDay;
	public uint obtainCoinLimit;
	public uint activityId;
	public uint[] watcherIdList;
	public uint dungeonId;
	public uint[] miniGameList;
	public uint[] monsterList;
	public uint[] energyGradeList;
	public uint initialEnergy;
	public uint energyLimit;
	public uint successRewardId;
	public uint failureRewardId;
	public uint punishTime;
	public uint titleTextMapHash;
	public uint descTextMapHash;
}