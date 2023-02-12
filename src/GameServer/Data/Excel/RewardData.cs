using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("RewardExcelConfigData.json")]
public class RewardData : OutputControlConfig
{
	public uint rewardId;
	public uint hcoin;
	public uint scoin;
	public uint playerExp;
	public uint avatarExp;
	public uint fetterExp;
	public uint resin;
	public RewardItemConfig[] rewardItemList;

	public class RewardItemConfig
	{
		public uint itemId;
		public uint itemCount;
	}
}
public abstract class OutputControlConfig
{
}