using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ProductConcertPackageDetailConfig : ProductDetailConfig
{
	public string originalPriceTier;
	public float discountRate;
	public uint showId;
	public uint replaceMcoinNum;
	public string icon;
	public uint rankLevel;
	public uint itemNameTextMapHash;
	public uint itemDescTextMapHash;
	public uint sortLevel;
	public string beginTime;
	public string endTime;
}