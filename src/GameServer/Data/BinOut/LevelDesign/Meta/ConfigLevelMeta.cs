using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLevelMeta
{
	public Dictionary<uint, ConfigSceneMeta> sceneMetaDic;

	public class ConfigSceneMeta
	{
		public ConfigLevelBlockMeta[] blockInfo;

		public class ConfigLevelBlockMeta
		{
			public uint blockID;
			public bool isIgnoreBlockPosition;
			public short blockCenterX;
			public short blockCenterZ;
		}
	}
}