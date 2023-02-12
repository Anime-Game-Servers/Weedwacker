using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class TalkExcelConfig
{
	public uint id;
	public TalkBeginWay beginWay;
	public PlayMode activeMode;
	public LogicType beginCondComb;
	public TalkCond[] beginCond;
	public uint priority;
	public uint[] nextTalks;
	public uint initDialog;
	public uint decoratorID;
	public uint[] nextRandomTalks;
	public int showRandomTalkCount;
	public uint[] npcId;
	public uint[] participantId;
	public string performCfg;
	public TalkHeroType heroTalk;
	public TalkLoadType loadType;
	public uint questId;
	public uint[] extraLoadMarkId;
	public bool dontBlockDaily;
	public string prePerformCfg;
	public bool stayFreeStyle;
	public bool enableCameraDisplacement;
	public bool lockGameTime;
	public TalkMarkType talkMarkType;
	public uint[] talkMarkHideList;
	public int[] crowdLOD0List;
	public bool questIdleTalk;
	public bool lowPriority;
	public TalkExec[] finishExec;

	public class TalkExec
	{
		public TalkExecType type;
		public string[] param;
	}
}