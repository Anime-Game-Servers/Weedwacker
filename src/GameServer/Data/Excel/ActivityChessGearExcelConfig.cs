using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityChessGearExcelConfig
{
	public uint gearID;
	public uint gearNameTextMapHash;
	public uint gearShortNameTextMapHash;
	public uint descTextMapHash;
	public string gearIconPath;
	public string tagIconPath;
	public int attack;
	public int mastery;
	public int attackSpeed;
	public int attackRange;
	public uint build_cost;
	public uint demolition_refund;
	public uint gadget_id;
	public uint build_limit;
	public uint[] ban_dungeon_list;
	public bool isEnableRotate;
	public uint initLevel;
	public uint needChessLevel;
}