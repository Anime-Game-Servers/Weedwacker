using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigEntityBanData
{
	public Dictionary<string, ConfigEntityBlackGrp[]> entityBanMap;

	public class ConfigEntityBlackGrp
	{
		public bool isBlack;
		public EntityType entityType;
		public uint[] entityIds;
	}
}