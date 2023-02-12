using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("SceneExcelConfigData.json")]
public class SceneData
{
	public uint id;
	public SceneType type;
	public SceneSubType subtype;
	public bool ignoreNavMesh;
	public NavmeshModeType navmeshMode;
	public string scriptData;
	public string overrideDefaultProfile;
	public string levelEntityConfig;
	public uint entityAppearSorted;
	public uint[] specifiedAvatarList;
	public uint maxSpecifiedAvatarNum;
	public float sceneFixTime;
	public string comment;
	public uint safePoint;
	public SceneMpType mpType;
	public bool isAllowMapMarkPoint;
	public bool isDeleteMapMarkPoint;
	public uint[] dungeonEntryPoint;
}
