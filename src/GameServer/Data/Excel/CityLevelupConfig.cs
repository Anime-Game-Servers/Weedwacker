using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CityLevelupConfig
{
	public uint scene_id;
	public uint city_id;
	public uint level;
	public WorldAreaLevelupConsumeItem consume_item;
	public uint rewardID;
	public WorldAreaLevelupAction[] action_vec;
}