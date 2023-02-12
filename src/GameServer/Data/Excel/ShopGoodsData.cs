using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("ShopGoodsExcelConfigData.json")]
public class ShopGoodsData
{
	public uint goodsId;
	public uint subTagNameTextMapHash;
	public uint subTabId;
	public uint shopType;
	public uint itemId;
	public uint rotateId;
	public uint showId;
	public uint itemCount;
	public uint costScoin;
	public uint costHcoin;
	public uint costMcoin;
	public float discountRate;
	public uint originalPrice;
	public IdCountConfig[] costItems;
	public uint buyLimit;
	public ShopRefreshType refreshType;
	public uint refreshParam;
	public uint displayDaysBeforeSell;
	public string beginTime;
	public string endTime;
	public bool isBuyOnce;
	public ShopPrecondition precondition;
	public uint preconditionParam;
	public string[] preconditionParamList;
	public bool preconditionHidden;
	public uint minShowLevel;
	public uint minPlayerLevel;
	public uint maxPlayerLevel;
	public uint sortLevel;
	public uint secondarySheetId;
	public uint chooseOneGroupId;
	public uint[] platformTypeList;
}
