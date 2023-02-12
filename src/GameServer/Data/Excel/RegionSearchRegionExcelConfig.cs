using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RegionSearchRegionExcelConfig
{
	public uint id;
	public float[] regionCenter;
	public float regionRadius;
	public uint[] oneoffGroupList;
	public uint oneoffGroupNum;
	public uint[] recycleGroupList;
	public uint recycleGroupNum;
	public RegionSearchRecycleType recycleType;
	public uint recycleParam;
}