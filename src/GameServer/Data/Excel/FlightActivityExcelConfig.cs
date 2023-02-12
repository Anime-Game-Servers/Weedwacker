using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FlightActivityExcelConfig
{
	public uint id;
	public uint activity_id;
	public uint preview_reward_id;
	public uint start_quest_id;
	public uint npc_id;
	public uint[] medal_id;
	public FlightDailyPointFactor[] daily_factor_vec;

	public class FlightDailyPointFactor
	{
		public uint time_factor;
		public uint gold_factor;
	}
}