using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ForgeExcelConfig
{
	public uint id;
	public uint playerLevel;
	public bool isDefaultShow;
	public uint[] effectiveWorldLevels;
	public uint forgeType;
	public uint showItemId;
	public uint showConsumeItemId;
	public uint resultItemId;
	public uint resultItemCount;
	public uint mainRandomDropId;
	public uint mainForgeRandomId;
	public uint forgeTime;
	public uint queueNum;
	public uint scoinCost;
	public RandomItemConfig[] randomItems;
	public IdCountConfig[] materialItems;
	public uint priority;
	public uint forgePoint;
	public uint forgePointNoticeTextMapHash;
}