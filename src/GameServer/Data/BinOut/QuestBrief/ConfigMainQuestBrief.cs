using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMainQuestBrief
{
	public uint id;
	public uint series;
	public QuestType type;
	public MainQuestTagType mainQuestTag;
	public uint titleTextMapHash;
	public uint descTextMapHash;
	public uint recommendLevel;
	public uint[] suggestTrackMainQuestList;
	public uint[] rewardIdList;
	public QuestShowType showType;
	public uint[] specialShowRewardId;
	public uint[] specialShowCondIdList;
	public uint specialShowQuestId;
	public uint chapterId;
	public uint taskID;
	public ConfigQuestScheme[] subQuests;
}