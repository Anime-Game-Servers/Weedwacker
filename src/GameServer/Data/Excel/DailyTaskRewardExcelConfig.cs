using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DailyTaskRewardExcelConfig
{
	public uint ID;
	public DailyTaskDropConfig[] dropVec;

	public class DailyTaskDropConfig
	{
		public uint drop_id;
		public uint preview_reward_id;
	}
}