using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigFaceAnimationGlobal
{
	public Dictionary<string, FaceAnimationTypeConfig> typeDefines;
	public Dictionary<uint, FaceAnimationTSettingPathConfig> pathDefines;
}