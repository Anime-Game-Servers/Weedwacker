using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextConditionChapterQuestState : ContextCondition
{
	public uint chapterId;
	public QuestState state;
	public bool startOrEndQuest;
}