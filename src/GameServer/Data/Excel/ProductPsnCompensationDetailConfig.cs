using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ProductPsnCompensationDetailConfig : ProductDetailConfig
{
	public PackageContentConfig[] contentVec;
	public uint mailConfigId;
	public uint limitCount;
}