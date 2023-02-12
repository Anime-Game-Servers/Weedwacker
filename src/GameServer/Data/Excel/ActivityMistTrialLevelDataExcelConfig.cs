using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityMistTrialLevelDataExcelConfig
{
	public uint Id;
	public uint scheduleId;
	public uint levelId;
	public uint levelTitleTextMapHash;
	public uint levelDescTextMapHash;
	public uint[] monsterPreviewIdList;
	public uint[] keyMonsterPreviewIdList;
	public uint openDay;
	public uint[] challengeMissionWatcherList;
	public uint[] statisticsIdList;
	public byte bgIconHashPre;
	public uint bgIconHashSuffix;
	public uint dungeonId;
	public uint[] dungeonFactorIdList;
	public string[] failTips;
	public uint[] trialAvatarIdList;
	public string serverGlobalValueKey;
	public uint[] floorLevelList;
	public uint[] battleStatisticsData;
}