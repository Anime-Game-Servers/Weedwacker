using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigBillboard
{
	public string attachPoint;
	public Vector offset;
	public BillboardOffsetType offsetType;
	public float radiusOffset;
	public bool enableSelfAdapt;
	public float showDistance;
	public float markShowDistance;
	public float nameShowDistance;
	public bool forceHideAllBars;
}