using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HandbookQuestGuideExcelConfig
{
	public uint guideID;
	public uint typeID;
	public uint labelTextMapHash;
	public uint mainQuestID;
	public uint chapterID;
	public QuestType questType;
	public uint order;
	public string icon;
	public bool isHidenWQ;
	public uint hidenSubQuestID;
	public uint markPointID;
	public uint specialGuideID;
	public bool showLabelTip;
	public HandbookQuestGuideShowCond[] showConds;

	public class HandbookQuestGuideShowCond
	{
		public HandbookQuestGuideShowCondType type;
		public uint[] param;
	}
}