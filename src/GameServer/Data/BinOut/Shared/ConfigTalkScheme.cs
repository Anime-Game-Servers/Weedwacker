using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared;

public class ConfigTalkScheme
{
	public uint id;
	public TalkBeginWay beginWay;
	public PlayMode activeMode;
	public LogicType beginCondComb;
	public TalkCondEx[] beginCond;
	public uint priority;
	public uint[] nextTalks;
	public uint[] nextRandomTalks;
	public int showRandomTalkCount;
	public uint initDialog;
	public uint decoratorID;
	public uint[] npcId;
	public string performCfg;
	public TalkHeroType heroTalk;
	public TalkLoadType loadType;
	public uint questId;
	public uint[] extraLoadMarkId;
	public ulong assetIndex;
	public bool dontBlockDaily;
	public uint[] participantId;
	public string prePerformCfg;
	public bool stayFreeStyle;
	public bool enableCameraDisplacement;
	public bool lockGameTime;
	public TalkMarkType talkMarkType;
	public bool questIdleTalk;
	public bool lowPriority;
	public TalkExecEx[] finishExec;
	public int[] prePerformFreeStyleList;
	public int[] freeStyleList;
	public uint[] talkMarkHideList;
	public int[] crowdLOD0List;

	public class TalkCondEx
	{
		public QuestCondType type;
		public string[] param;
	}
	public class TalkExecEx
	{
		public TalkExecType type;
		public string[] param;
	}
}