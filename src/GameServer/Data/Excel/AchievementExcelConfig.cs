using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class AchievementExcelConfig : WatcherConfig
{
	public uint goalId;
	public uint orderId;
	public uint preStageAchievementId;
	public uint titleTextMapHash;
	public uint descTextMapHash;
	public ShowType isShow;
	public uint ps4GroupId;
	public uint ps5GroupId;
	public uint ps5TitleTextMapHash;
	public string ttype;
	public string psTrophyId;
	public string ps4TrophyId;
	public string ps5TrophyId;
	public string icon;
	public uint finishRewardId;
	public bool isDeleteWatcherAfterFinish;
	public ProgressShowType progressShowType;
}