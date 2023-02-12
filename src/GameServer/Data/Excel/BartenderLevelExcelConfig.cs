using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BartenderLevelExcelConfig
{
	public uint id;
	public uint levelNameTextMapHash;
	public uint unlockDay;
	public uint levelDuration;
	public uint[] orderList;
	public uint orderCD;
	public uint[] watcherIdList;
	public uint levelDescriptionTextMapHash;
}