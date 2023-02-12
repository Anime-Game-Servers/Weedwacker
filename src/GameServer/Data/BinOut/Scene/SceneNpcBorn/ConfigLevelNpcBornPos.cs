using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Scene.SceneNpcBorn;

public class ConfigLevelNpcBornPos
{
	public uint sceneId;
	public ConfigNpcBornPos[] bornPosList;

	public class ConfigNpcBornPos
	{
		public uint id;
		public uint configId;
		public uint roomId;
		public Vector pos;
		public Vector rot;
		public uint groupId;
		public uint suiteId;
		public uint[] suiteIdList;
	}
}
