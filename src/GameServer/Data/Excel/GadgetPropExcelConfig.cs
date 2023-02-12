using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class GadgetPropExcelConfig
{
	public uint id;
	public float hp;
	public GrowCurveType hpCurve;
	public float attack;
	public GrowCurveType attackCurve;
	public float defense;
	public GrowCurveType defenseCurve;
}