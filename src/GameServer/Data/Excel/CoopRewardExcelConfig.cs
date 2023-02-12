using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CoopRewardExcelConfig
{
	public uint id;
	public CoopCondConfig[] rewardCond;
	public uint chapterId;
	public uint rewardId;
	public uint sortId;
	public uint condTipTextMapHash;
	public uint condTipDesTextMapHash;
}