using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAnimator
{
	public Dictionary<int, string[]> freeStyleStateMap;
	public Dictionary<string, ulong> stateAnimeMap;
	public Dictionary<AnimeGroupType, ConfigAnimGroup> logicStateMap;

	public class ConfigAnimGroup
	{
		public Dictionary<string, ulong> dynamicAnimeMap;
	}
}