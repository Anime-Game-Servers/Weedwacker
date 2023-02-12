using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("ShopExcelConfigData.json")]
public class ShopData
{
	public uint shopId;
	public ShopType shopType;
	public ShopRefreshType refreshType;
	public uint refreshParam;
	public OpenStateType openStateType;
	public uint cityId;
	public uint cityDiscountLevel;
	public uint scoinDiscountRate;
	public uint vipFuncID;
}
