using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideSceneIdCondition : ConfigGuideCondition
{
	public uint sceneId;
	public uint[] sceneIdList;
	public bool isScene;
}