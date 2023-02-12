using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ProductCardDetailConfig : ProductDetailConfig
{
	public CardProductType cardProductType;
	public uint itemNameTextMapHash;
	public string icon;
	public uint totalLimitDays;
	public uint days;
	public uint hcoinPerDay;
	public uint mcoinBase;
	public Dictionary<uint, uint> baseItemMap;
	public Dictionary<uint, uint> perDayItemMap;
	public uint replaceMcoinNum;
	public uint firstRewardTextTextMapHash;
	public uint dailyRewardTextTextMapHash;
	public uint totalRewardTextTextMapHash;
	public uint totalDaysTextTextMapHash;
	public uint remainDaysTextTextMapHash;
	public uint remainDaysText2TextMapHash;
	public uint explainTitleTextMapHash;
	public uint explainDescTextMapHash;
	public uint sortLevel;
}