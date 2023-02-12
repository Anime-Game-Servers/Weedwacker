using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCombatBillboard : ConfigBillboard
{
	public bool showHPBar;
	public float forceShowDistance;
	public CombatBillboardSize size;
	public bool shieldBarOnly;
}