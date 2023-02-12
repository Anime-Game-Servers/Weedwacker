using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Gadget;

public class ConfigGear
{
	public GearType gearType;
	public ElementType startElemType;
	public uint startValue;
	public uint startLastTime;
	public ElementType stopElemType;
	public uint stopValue;
	public uint stopLastTime;
}