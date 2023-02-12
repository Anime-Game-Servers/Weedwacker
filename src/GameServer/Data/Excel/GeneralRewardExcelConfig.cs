using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class GeneralRewardExcelConfig
{
	public uint id;
	public bool useCondenseResin;
	public RewardSourceSystemType rewardSourceSystem;
	public uint rewardSourceSystemPara;
	public uint titleTextMapHash;
	public uint staminaEnoughTextMapHash;
	public uint staminaLessTextMapHash;
	public uint condenseResinStaminaEnoughTextMapHash;
	public uint condenseResinStaminaLessTextMapHash;
	public uint usingActivityCoinTextMapHash;
	public uint usingActivityCoinButtonTextMapHash;
	public uint confirmTextMapHash;
	public uint resinMonthlyTextMapHash;
	public uint insufficientTextMapHash;
	public uint insufficientUseitemTextMapHash;
	public uint condenseResinTextMapHash;
}