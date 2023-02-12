using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class TransPointRewardConfig
{
	public uint scene_id;
	public uint point_id;
	public uint reward_id;
	public uint[] group_id_vec;
	public uint[] unlock_area_id_vec;
}