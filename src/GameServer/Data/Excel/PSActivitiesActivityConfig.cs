using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class PSActivitiesActivityConfig : PSActivitiesBaseConfig
{
	public uint activityNameTextMapHash;
	public uint activityDescTextMapHash;
	public PSActivitiesCategoryType category;
	public bool availableByDefault;
	public bool isRequiredForCompletion;
	public bool hidden;
	public bool isOnlineMultiplay;
	public string largeIcon;
	public string smallIcon;
}