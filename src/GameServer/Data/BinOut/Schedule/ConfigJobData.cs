using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigJobData
{
	public Dictionary<int, Dictionary<int, ConfigJob>> jobMapData;

	public class ConfigJob
	{
		public bool isForceMainThread;
		public ConfigScheduleJobType scheduleJobType;
		public ConfigSchedulerType scheduleType;
		public int maxNodeNum;
		public int groupId;
	}
}