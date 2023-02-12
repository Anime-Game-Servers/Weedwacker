using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BartenderOrderExcelConfig
{
	public uint id;
	public uint formulaId;
	public uint[] affixId;
	public BartenderCupType cupType;
	public uint time;
	public uint score;
	public string iconName;
	public uint descTextMapHash;
}