using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LevelTagGroupsExcelConfig
{
	public uint ID;
	public LevelTagGroup[] levelTagGroupList;
	public uint[] initialLevelTagIdList;
	public uint changeCd;

	public class LevelTagGroup
	{
		public uint[] levelTagIdList;
	}
}