using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideCheckQuestStateCondition : ConfigGuideCondition
{
	public uint questId;
	public uint questState;
	public bool isEqual;
}