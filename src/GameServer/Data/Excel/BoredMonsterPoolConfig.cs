using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BoredMonsterPoolConfig
{
	public uint id;
	public uint monster_id;
	public uint level;
	public string dropTag;
	public uint[] affixVec;
	public bool isElite;
}