using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MatchExcelConfig
{
	public uint id;
	public MatchSubType matchSubType;
	public uint minPlayerNum;
	public uint maxPlayerNum;
	public uint confirmTime;
	public bool isContinueMatch;
}