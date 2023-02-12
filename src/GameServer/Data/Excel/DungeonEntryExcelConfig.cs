using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DungeonEntryExcelConfig
{
	public uint id;
	public uint sceneId;
	public uint dungeon_entry_id;
	public DungunEntryType type;
	public bool isShowInAdvHandbook;
	public uint descTextMapHash;
	public uint[] cooldown_tips_dungeon_id;
	public bool is_default_open;
	public bool is_daily_refresh;
	public LogicType cond_comb;
	public DungeonEntrySatisfiedCond[] satisfied_cond;
	public string pic_path;
	public uint system_open_ui_id;
	public uint reward_data_id;
	public uint[][] description_cycle_reward_list;

	public class DungeonEntrySatisfiedCond
	{
		public DungeonEntrySatisfiedConditionType type;
		public uint param1;
		public uint param2;
	}
}