using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class GlobalWatcherConfig : WatcherConfig
{
	public WatcherPredicateConfig[] predicateConfigs;

	public class WatcherPredicateConfig
	{
		public WatcherPredicateType predicateType;
		public uint[] paramList;
	}
}