using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextConditionQuestState : ContextCondition
{
	public uint questId;
	public QuestState state;
}