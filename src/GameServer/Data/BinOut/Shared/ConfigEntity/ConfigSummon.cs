using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigSummon
{
	public ConfigSummonTag[] summonTags;

	public class ConfigSummonTag
	{
		public uint summonTag;
		public string name;
		public int maxNum;
		public bool copyOwnerThreatList;
		public bool useOwnerDefendArea;
	}
}
