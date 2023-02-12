using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityGearExcelConfig
{
	public uint id;
	public uint activityId;
	public uint[] gearLevelIdList;
	public float gearToothLength;
	public float gearThickness;
	public string shaftSelectEffect;
	public string shaftTipEffect;
	public string endGearSuccessEffect;
	public string coverUpEffect;
	public string gearPlaceEffect;
	public uint pushTipsId;
	public uint[] watcherIdList;
	public float playerTipDelay;
}