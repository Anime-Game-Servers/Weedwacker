using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HomeWorldLimitShopExcelConfig
{
	public uint goodsId;
	public uint itemID;
	public uint poolID;
	public HomeWorldLimitShopCond[] cond;
	public uint buyLimit;
	public IdCountConfig[] costItems;
	public uint weight;

	public class HomeWorldLimitShopCond
	{
		public HomeWorldLimitShopCondType condition;
		public uint[] conditionParam;
	}
}