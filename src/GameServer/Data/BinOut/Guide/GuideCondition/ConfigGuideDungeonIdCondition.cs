using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideDungeonIdCondition : ConfigGuideCondition
{
	public uint dungeonId;
	public uint[] dungeonIdList;
	public bool isDungeon;
}