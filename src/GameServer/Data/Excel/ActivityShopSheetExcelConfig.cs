using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityShopSheetExcelConfig
{
	public uint id;
	public bool isAheadPreview;
	public LogicType condComb;
	public uint SheetNameTextMapHash;
	public ActivityShopSheetCond[] cond;
	public uint[] sortLevel;

	public class ActivityShopSheetCond
	{
		public ActivityShopSheetCondType type;
		public uint[] param;
	}
}