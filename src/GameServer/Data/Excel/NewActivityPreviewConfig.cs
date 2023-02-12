using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class NewActivityPreviewConfig
{
	public uint activityID;
	public uint descTextMapHash;
	public uint intro_titleTextMapHash;
	public uint intro_contentTextMapHash;
	public uint rewardPreviewID;
	public uint preQuestID;
	public uint[] middleQuestIDList;
	public uint[] middleQuestFinishIDList;
	public uint openQuestID;
	public uint pushTipsID;
	public uint[] openMainQuestIDList;
	public uint[] preMainQuestIDList;
	public PreviewActivityCond[] preActivityCondition;
	public bool isBlocked;

	public class PreviewActivityCond
	{
		public uint condtionId;
		public string desc;
	}
}