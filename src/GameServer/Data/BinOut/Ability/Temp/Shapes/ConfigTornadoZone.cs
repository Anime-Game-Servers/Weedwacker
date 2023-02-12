using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp;

public class ConfigTornadoZone
{
	public string shapeName;
	public Vector offset;
	public Vector dir;
	public object strength;
	public object attenuation;
	public object innerRadius;
	public string modifierName;
	public uint maxNum;
	public float forceGrowth;
	public float forceFallen;
	public float duration;
}