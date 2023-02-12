using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("LunaRiteSearchingExcelConfigData.json")]
public class LunaRiteSearchingData
{
	public uint Id;
	public LunaRiteRegionType regionType;
	public uint openDay;
	public uint progressWatcherID;
	public uint[] watcherID;
	public float[] regionCenter;
	public byte regionNameHashPre;
	public uint regionNameHashSuffix;
	public float regionRadius;
	public uint chestCond;
	public uint runeCond;
	public uint chestMarkNum;
	public uint runeMarkNum;
}