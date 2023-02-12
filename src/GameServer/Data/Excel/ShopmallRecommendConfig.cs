using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ShopmallRecommendConfig
{
	public uint Id;
	public uint subTabId;
	public ShopRecommendTabType tabType;
	public ShopType shopType;
	public uint[] goodsIdVec;
	public uint[] configIdVec;
	public LogicType condComb;
	public ShopmallRecommendCond[] condVec;
	public uint order;
	public ShopRecommendTagType tagType;
	public string oneCardIconName;
	public string[] colShowIconName;
	public uint jumpEntranceId;
	public bool showSaleRemainTime;

	public class ShopmallRecommendCond
	{
		public ShopmallRecommendCondType type;
		public string param1Str;
		public string param2Str;
		public uint param1;
		public uint param2;
	}
}