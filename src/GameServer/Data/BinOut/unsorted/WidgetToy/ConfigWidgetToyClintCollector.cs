using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetToyClintCollector : ConfigBaseWidgetToy
{
	public CollectorType targetType;
	public ElementType elementType;
	public uint rechargePoints;
	public uint maxPoints;
	public uint effectGadgetId;
	public uint useGadgetId;
	public bool allowOtherWorld;
}