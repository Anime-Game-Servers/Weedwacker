using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextConditionMainQuestState : ContextCondition
{
	public uint mainQuestId;
	public QuestState state;
}