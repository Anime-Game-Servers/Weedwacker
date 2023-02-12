using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCrowdGroupInfo
{
	public int crowdGroupID;
	public Vector boundCenter;
	public Vector boundSize;
	public bool spawnByDefault;
	public ConfigCrowdRestrictionGroup[] crowdRestrictionGroups;
	public int cutsceneID;
	public bool ignoreLowPerfMode;
	public uint[] jointBlocks;
	public bool canBeOptimized;
}