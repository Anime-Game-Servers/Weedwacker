using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RandomMainQuestExcelConfig
{
	public uint id;
	public QuestType type;
	public uint titleTextMapHash;
	public uint descTextMapHash;
	public string luaPath;
	public uint recommendLevel;
	public bool repeatable;
	public PlayMode activeMode;
	public uint[] suggestTrackMainQuestList;
	public bool suggestTrackOutOfOrder;
	public QuestShowType showType;
	public uint chapterId;
	public string rewardIdList;
}