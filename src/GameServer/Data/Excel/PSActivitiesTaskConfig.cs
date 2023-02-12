using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class PSActivitiesTaskConfig : PSActivitiesBaseConfig
{
	public uint activityID;
	public uint taskNameTextMapHash;
	public bool isRequiredForCompletion;
	public bool hidden;
}