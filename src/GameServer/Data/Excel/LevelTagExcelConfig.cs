using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LevelTagExcelConfig
{
	public uint ID;
	public string levelTagName;
	public uint sceneId;
	public uint[] addSceneTagIdList;
	public uint[] removeSceneTagIdList;
	public bool levelTagCanFixTime;
	public float levelTagFixedEnviroTime;
	public uint[] loadDynamicGroupList;
}