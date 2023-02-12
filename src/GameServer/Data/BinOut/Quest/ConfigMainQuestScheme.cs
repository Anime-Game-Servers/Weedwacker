using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Quest;

public class ConfigMainQuestScheme
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
	public uint[] specialShowRewardId;
	public uint[] specialShowCondIdList;
	public uint specialShowQuestId;
	public uint chapterId;
	public uint taskID;
	public bool showRedPoint;
	public uint activityId;
	public ConfigQuestScheme[] subQuests;
	public ConfigTalkScheme[] talks;
	public ulong[] preloadLuaList;
	public ulong[] forcePreloadLuaList;
	public Dictionary<uint, int[]> freeStyleDic;
}
