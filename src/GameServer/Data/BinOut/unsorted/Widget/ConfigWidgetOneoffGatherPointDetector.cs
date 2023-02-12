using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetOneoffGatherPointDetector : ConfigBaseWidget
{
	public uint hintRadius;
	public uint nearbyRadius;
	public uint gridSearchRange;
	public uint successGadgetId;
	public uint failedGadgetId;
	public uint gatherPointType;
	public uint hintGroup;
	public uint effectLastTime;
	public float distanceToAvatar;
	public float height;
}