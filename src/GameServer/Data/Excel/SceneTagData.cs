using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("SceneTagConfigData.json")]
public class SceneTagData
{
	public uint id;
	public string sceneTagName;
	public uint sceneId;
	public bool isDefaultValid;
	public bool isSkipLoading;
	public bool isIndependent;
	public SceneTagCond[] cond;

	public class SceneTagCond
	{
		public SceneTagCondType condType;
		public long param1;
		public long param2;
	}
}
