using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextConditionChapterQuestVisible : ContextCondition
{
	public uint chapterId;
	public bool visible;
}