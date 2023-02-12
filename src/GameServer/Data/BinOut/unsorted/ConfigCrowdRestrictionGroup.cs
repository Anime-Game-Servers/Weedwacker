using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCrowdRestrictionGroup
{
	public CrowdSpawnConditionType spawnCondition;
	public ConfigCrowdQuestRestriction[] questRes;
	public ConfigCrowdActivityRestriction[] activityRes;
	public ConfigCrowdTimeRestriction[] timeRes;
	public ConfigCrowdSceneTagRestriction[] sceneTags;
}