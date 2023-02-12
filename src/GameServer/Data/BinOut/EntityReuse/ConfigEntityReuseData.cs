using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigEntityReuseData
{
	public ConfigEntityReuse[] entityReuseList;

	public class ConfigEntityReuse
	{
		public uint configId;
		public float destroyTime;
		public uint maxEntityCount;
	}
}