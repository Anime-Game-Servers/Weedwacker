using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ReactionEnergyExcelConfig
{
	public ElementReactionType type;
	public float minDurability;
	public float maxDurability;
	public float costRatio;
	public uint configID;
	public float poolSize;
	public float poolRevivePeriod;
	public float poolReviveEnergy;
	public bool isPersistent;
	public float costPeriod;
	public uint dropProb;
}