using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPlatformActionTokenChannel
{
	public EntityType[] highEntityTypes;
	public EntityType[] lowEntityTypes;
	public Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> entityTypeToken;
	public ConfigActionTokenChannelGroupInfo defaultCfg;
	public Dictionary<string, ConfigActionTokenChannelGroupInfo> platformCfg;
	public Dictionary<EntityTokenActionType, int> actionConsumeTokenLimit;

	public class ConfigEntityActionTokenGroup
	{
		public ConfigAbilityActionToken lowEntityToken;
		public ConfigAbilityActionToken otherEntityToken;
		public bool useHighEntityTypes;
	}
	public class ConfigActionTokenChannelGroupInfo
	{
		public float lowLevelDist;
		public Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> lowLevelDistToken;
		public Dictionary<ActionTokenSourceType, Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup>> actionSourceToken;
		public Dictionary<int, ConfigActionTokenChannel> cfg;

		public class ConfigActionTokenChannel
		{
			public int maxNum;
		}
	}
}