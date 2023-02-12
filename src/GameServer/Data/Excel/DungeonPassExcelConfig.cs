using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DungeonPassExcelConfig
{
	public uint id;
	public LogicType logicType;
	public DungeonCondConfig[] conds;

	public class DungeonCondConfig
	{
		public DungeonCondType condType;
		public int[] param;
	}
}