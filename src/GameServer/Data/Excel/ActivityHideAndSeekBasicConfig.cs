using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityHideAndSeekBasicConfig
{
	public uint id;
	public uint activityID;
	public uint titleTextMapHash;
	public uint descTextMapHash;
	public uint pushTipsID;
	public uint rewardPreviewID;
	public uint oneTimeRewardPreviewID;
	public uint unlockQuestID;
	public uint matchID;
	public uint draftID;
	public uint[] scoreUnlockList;
	public uint[] watcherList;
	public uint[] skillList;
	public uint[] mapList;
	public uint[] chanllengeList;
	public uint scoreItemID;
}