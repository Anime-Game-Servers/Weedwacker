using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public class DungeonEntry : SceneTransPoint
{
	public uint[] dungeonIds;
	public DungeonQuestCondition dungeonQuestConditionList;
	public Vector size;
	public uint worktopGroupId;
	public string titleTextID;
	public int showLevel;
	public uint[] dungeonRandomList;
	public DungeonEntryType dungeonEntryType;
	public bool forbidSimpleUnlock;
	public bool fireFieldEvent;
	public uint[] dungeonRosterList;
	public bool removeEntityIfLocked;

	public class DungeonQuestCondition
	{
		public uint dungeonId;
		public uint[] mainQuestIdList;
	}
}
