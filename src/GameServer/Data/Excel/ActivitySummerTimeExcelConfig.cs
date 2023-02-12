using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivitySummerTimeExcelConfig
{
	public uint Id;
	public uint unlockQuestID;
	public uint contentDuration;
	public uint unlockPlayerLevel;
	public uint personalPreQuest;
	public uint[] preQuestOfPreQuest;
	public uint rewardPreview;
	public uint[] questIdList;
}