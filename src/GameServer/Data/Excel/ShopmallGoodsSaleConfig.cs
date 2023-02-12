using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ShopmallGoodsSaleConfig
{
	public uint Id;
	public uint goodsId;
	public uint discountScoin;
	public uint discountHcoin;
	public uint discountMcoin;
	public float discountRate;
	public string discountBeginTime;
	public string discountEndTime;
	public uint discountBeginTimestamp;
	public uint discountEndTimestamp;
}