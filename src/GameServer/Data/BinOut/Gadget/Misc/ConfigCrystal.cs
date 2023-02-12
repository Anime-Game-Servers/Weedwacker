using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Gadget;

public class ConfigCrystal
{
	public ElementType elementType;
	public uint gainSpeed;
	public uint drainSpeed;
	public uint[] resonateLevels;
	public uint burstResonate;
	public string burstSkill;
	public uint burstTime;
	public uint respawnTime;
}