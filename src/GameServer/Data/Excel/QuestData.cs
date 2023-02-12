using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Data.Excel.Common;

namespace Weedwacker.GameServer.Data.Excel;
[Resource("QuestExcelConfigData.json")]
public class QuestData
{
	public uint subId;
	public uint mainId;
	public int order;
	public uint subIdSet;
	public bool isMpBlock;
	public uint descTextMapHash;
	public uint stepDescTextMapHash;
	public uint guideTipsTextMapHash;
	public QuestShowType showType;
	public BanGroupType banType;
	public LogicType acceptCondComb;
	public QuestCond[] acceptCond;
	public LogicType finishCondComb;
	public QuestContent[] finishCond;
	public LogicType failCondComb;
	public QuestContent[] failCond;
	public QuestGuide guide;
	public ShowQuestGuideType showGuide;
	public bool finishParent;
	public bool failParent;
	public QuestShowType failParentShow;
	public bool isRewind;
	public QuestExec[] finishExec;
	public QuestExec[] failExec;
	public QuestExec[] beginExec;
	public uint[] exclusiveNpcList;
	public uint[] sharedNpcList;
	public uint exclusiveNpcPriority;
	public uint[] trialAvatarList;
	public uint[] exclusivePlaceList;

	public class QuestCond
	{
		public QuestCondType type;
		public int[] param;
	}
	public class QuestContent
	{
		public QuestContentType type;
		public int[] param;
		public string param_str;
		public uint count;
	}
}
