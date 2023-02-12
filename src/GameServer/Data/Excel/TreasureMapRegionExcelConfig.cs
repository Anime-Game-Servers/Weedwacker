using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class TreasureMapRegionExcelConfig
{
	public uint id;
	public uint unlock_day;
	public uint token_num;
	public float[] region_center;
	public uint region_radius;
	public uint region_entry_id;
	public uint[] group_list;
	public uint revise_level;
	public uint[] spot_num_list;
	public uint[] token_num_list;
	public uint[] misc_drop_prob_list;
	public uint misc_drop_id;
	public uint mp_group_id;
	public uint[] backup_group_list;
	public uint mp_token_threshold;
	public uint mp_type_id;
	public float[] mp_position;
	public uint mp_descTextMapHash;
	public uint mp_reward_preview_id;
	public uint fragment_bonus_id;
}