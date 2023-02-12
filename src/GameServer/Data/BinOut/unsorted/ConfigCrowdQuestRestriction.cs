using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCrowdQuestRestriction
{
	public uint questID;
	public bool questAccepted;
	public QuestState[] questStates;
}