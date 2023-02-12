using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RogueTokenExcelConfig
{
	public uint id;
	public uint stageId;
	public uint level;
	public RogueMonsterPoolDifficultyType cellType;
	public uint[] coinANum;
	public uint[] coinBNum;
	public uint[] coinCNum;
}