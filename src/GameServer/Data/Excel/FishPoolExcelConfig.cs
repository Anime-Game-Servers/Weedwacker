using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FishPoolExcelConfig
{
	public uint id;
	public uint[] stockList;
	public Dictionary<uint, uint> stockGuarantee;
	public FishStockLimit[] stockLimitList;
	public uint maxNum;
	public uint poolNameTextMapHash;
	public uint poolDescTextMapHash;
	public string abilityGroup;
	public string teamAbilityGroup;
	public uint[] dropIdList;
	public uint dailyLimitNum;
	public uint[] excludeFish;
	public uint cityId;

	public class FishStockLimit
	{
		public FishStockType stockType;
		public uint minNum;
		public uint maxNum;
	}
}