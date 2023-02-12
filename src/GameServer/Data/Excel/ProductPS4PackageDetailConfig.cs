using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ProductPS4PackageDetailConfig : ProductDetailConfig
{
	public PackageContentConfig[] contentVec;
	public uint mailConfigId;
}