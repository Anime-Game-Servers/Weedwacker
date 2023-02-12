using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class WorldAreaLevelupConfig
{
	public uint scene_id;
	public uint area_id;
	public uint level;
	public WorldAreaLevelupConsumeItem consume_item;
	public uint rewardID;
	public WorldAreaLevelupAction[] action_vec;
}