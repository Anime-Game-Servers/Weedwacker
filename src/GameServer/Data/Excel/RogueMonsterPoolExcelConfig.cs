using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RogueMonsterPoolExcelConfig
{
	public uint id;
	public uint dungeonId;
	public RogueMonsterPoolDifficultyType difficulty;
	public uint[] poolIdList;
}