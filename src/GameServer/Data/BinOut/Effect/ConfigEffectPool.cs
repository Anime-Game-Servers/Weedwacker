using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigEffectPool
{
	public uint particleSystemBudgetSize;
	public uint particleSystemBudgetSizeLowMemory;
	public uint particleSystemBudgetSizeMidMemory;
	public uint effectpoolBudgetSize;
	public float releaseForBudgetTimeThreshold;
	public float releaseForBudgetTimeThresholdLowMemory;
	public float releaseForBudgetTimeThresholdMidMemory;
	public float releaseBudgetTimeThresholdPerFrame;
	public Dictionary<string, ConfigEffectPoolItem> poolItems;

	public class ConfigEffectPoolItem
	{
		public uint preinstantiateNumWhenPreload;
		public uint maxUsedSize;
	}
}