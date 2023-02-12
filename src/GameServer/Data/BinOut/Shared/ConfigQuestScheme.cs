using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared;

public class ConfigQuestScheme
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
	public QuestCondEx[] acceptCond;
	public LogicType finishCondComb;
	public QuestContentEx[] finishCond;
	public LogicType failCondComb;
	public QuestContentEx[] failCond;
	public QuestGuideEx guide;
	public ShowQuestGuideType showGuide;
	public bool finishParent;
	public bool failParent;
	public QuestShowType failParentShow;
	public bool isRewind;
	public QuestExecEx[] finishExec;
	public QuestExecEx[] failExec;
	public QuestExecEx[] beginExec;
	public uint[] exclusiveNpcList;
	public uint[] exclusivePlaceList;
	public uint[] sharedNpcList;
	public uint exclusiveNpcPriority;
	public uint[] trialAvatarList;
	public string versionBegin;
	public string versionEnd;

	public class QuestCondEx
	{
		public QuestCondType type;
		public int[] param;
	}
	public class QuestContentEx
	{
		public QuestContentType type;
		public int[] param;
		public uint count;
	}
	public class QuestExecEx
	{
		public QuestExecType type;
		public string[] param;
	}
	public class QuestGuideEx
	{
		public QuestGuideType type;
		public QuestGuideAuto autoGuide;
		public string[] param;
		public uint guideScene;
		public QuestGuideStyle guideStyle;
		public QuestGuideLayer guideLayer;
	}
}