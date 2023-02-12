using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigHomeFishpondSet
{
	public Dictionary<uint, ConfigHomeFishpond> fishpondMap;

	public class ConfigHomeFishpond
	{
		public uint maxFishCount;
		public ConfigHomeCommonPos[] fishBornPosList;

		public class ConfigHomeCommonPos
		{
			public Vector position;
			public Vector rotation;
		}
	}
}