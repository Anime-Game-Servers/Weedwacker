using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Data.Excel.Common;

namespace Weedwacker.GameServer.Data;

public class RandomQuestExcelConfig
{
	public uint subId;
	public uint mainId;
	public int order;
	public uint subIdSet;
	public uint titleTextMapHash;
	public uint descTextMapHash;
	public QuestShowType showType;
	public LogicType acceptCondComb;
	public RandomQuestCond[] acceptCond;
	public LogicType finishCondComb;
	public RandomQuestContent[] finishCond;
	public LogicType failCondComb;
	public RandomQuestContent[] failCond;
	public QuestGuide guide;
	public ShowQuestGuideType showGuide;
	public bool finishParent;
	public bool failParent;
	public QuestShowType failParentShow;
	public bool isRewind;
	public IdCountConfig[] awardItems;
	public QuestExec[] beginExec;
	public QuestExec[] finishExec;
	public QuestExec[] failExec;
	public uint exclusiveNpcPriority;
	public BanGroupType banType;

	public class RandomQuestCond
	{
		public QuestCondType type;
		public string[] param;
	}
	public class RandomQuestContent
	{
		public QuestContentType type;
		public string[] param;
		public string param_str;
		public string count;
	}
}