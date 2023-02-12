using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityGachaStageExcelConfig
{
	public uint stageId;
	public uint nextStageId;
	public bool isTech;
	public ActivityGachaTargetType type;
	public uint[] groupIdList;
	public uint[] groupNumList;
	public uint[] stageGroupIdList;
	public uint[] taskContentList;
	public uint condID;
	public bool isNeedFinish;
	public uint watcherID;
	public uint openQuestID;
}