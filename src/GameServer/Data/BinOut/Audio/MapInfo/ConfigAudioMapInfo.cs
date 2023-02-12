using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioMapInfo
{
	public ConfigWwiseString areaStateKey;
	public ConfigAudioMapArea[] areas;

	public class ConfigAudioMapArea
	{
		public uint id;
		public ConfigWwiseString stateValue;
		public ConfigWwiseString subStateGroup;
		public ConfigWwiseString defaultSubStateValue;
		public ConfigWwiseString[] eventsOnEnter;
		public ConfigWwiseString[] eventsOnExit;
	}
}