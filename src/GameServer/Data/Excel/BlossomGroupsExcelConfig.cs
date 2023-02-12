using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BlossomGroupsExcelConfig
{
	public uint id;
	public uint cityId;
	public uint sectionId;
	public uint[] refreshTypeVec;
	public uint[] newGroupVec;
	public uint[] decorateGroupVec;
	public uint[] nextCampIdVec;
	public bool is_safe;
	public bool is_initial_refresh;
	public uint finish_progress;
	public uint limit_level;
	public uint fight_radius;
	public uint remind_radius;
	public uint blossom_tipsTextMapHash;
	public uint delay_unload_sec;
}