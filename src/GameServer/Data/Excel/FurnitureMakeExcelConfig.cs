using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FurnitureMakeExcelConfig
{
	public uint configID;
	public uint furnitureItemID;
	public uint count;
	public uint exp;
	public IdCountConfig[] materialItems;
	public uint makeTime;
	public uint maxAccelerateTime;
	public uint quickFetchMaterialNum;
}