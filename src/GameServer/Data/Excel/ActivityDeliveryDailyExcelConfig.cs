using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityDeliveryDailyExcelConfig
{
	public uint dailyConfigId;
	public DeliveryQuestConfig[] deliveryQuestConfig;
	public uint[] taskDesc;
	public uint dailyRewardId;

	public class DeliveryQuestConfig
	{
		public uint parentQuestId;
		public uint deliveryQuestId;
		public uint startQuestId;
		public uint talkQuestId;
		public uint[] watcherId;
		public uint itemId;
	}
}