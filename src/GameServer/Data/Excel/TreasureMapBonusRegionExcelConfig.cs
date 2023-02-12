using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class TreasureMapBonusRegionExcelConfig
{
	public uint id;
	public uint unlock_region_id;
	public uint group_id;
	public uint reward_id;
	public uint reward_preview_id;
	public uint revise_level;
	public uint map_titleTextMapHash;
	public uint map_descTextMapHash;
	public string show_image;
	public uint fragment_num;
	public float[] region_center;
	public uint region_radius;
}