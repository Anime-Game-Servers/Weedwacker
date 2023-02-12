using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MainQuestExcelConfig
{
	public uint id;
	public uint resId;
	public uint series;
	public QuestType type;
	public MainQuestTagType mainQuestTag;
	public PlayMode activeMode;
	public uint titleTextMapHash;
	public uint descTextMapHash;
	public string luaPath;
	public uint recommendLevel;
	public bool repeatable;
	public uint[] suggestTrackMainQuestList;
	public bool suggestTrackOutOfOrder;
	public uint[] rewardIdList;
	public QuestShowType showType;
	public uint chapterId;
	public uint taskID;
	public bool showRedPoint;
	public uint activityId;
	public bool isRelease;
	public uint[] specialShowRewardId;
	public uint[] specialShowCondIdList;
	public uint specialShowQuestId;
}