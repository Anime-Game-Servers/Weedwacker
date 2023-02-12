using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCrowdActivityRestriction
{
	public uint activityType;
	public bool isActive;
	public uint[] activityPhase;
	public uint condID;
}