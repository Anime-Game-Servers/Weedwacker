using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DungeonRosterConfig
{
	public uint id;
	public string openTimeStr;
	public uint cycleTime;
	public DungeonRosterCycleType cycleType;
	public DungeonList[] rosterPool;
}