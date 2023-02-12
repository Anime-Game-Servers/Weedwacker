using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MichiaePreviewExcelConfig
{
	public uint activityID;
	public uint descTextMapHash;
	public uint intro_titleTextMapHash;
	public uint intro_contentTextMapHash;
	public uint rewardPreviewID;
	public uint pushTipsID;
	public uint bossGroupBundleId;
	public float radarSearchRadius;
	public float radarRemoveRadius;
	public uint allRadarShowLimit;
	public uint preSubQuestId;
	public uint preActivityQuestId;
	public uint activityQuestId;
	public Dictionary<uint, uint> preQuestIdMap;
	public uint[] preQuestIdList;
}