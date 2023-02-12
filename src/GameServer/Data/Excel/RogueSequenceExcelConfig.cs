using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RogueSequenceExcelConfig
{
	public uint id;
	public uint dungeonId;
	public uint sequenceId;
	public uint[] cellList;
	public Dictionary<uint, uint> cellPriority;
	public RogueSequenceCellConfig[] cellSeqList;

	public class RogueSequenceCellConfig
	{
		public RogueCellType type;
		public uint[] range;
	}
}