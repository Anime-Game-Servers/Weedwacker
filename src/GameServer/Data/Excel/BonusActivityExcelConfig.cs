using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BonusActivityExcelConfig : WatcherConfig
{
	public uint bonusActivityId;
	public LogicType condComb;
	public SignInCondConfig[] condList;
	public uint watcherId;
	public IdCountConfig[] rewardItemList;
}