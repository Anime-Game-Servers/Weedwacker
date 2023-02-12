using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideHasAvatarCondition : ConfigGuideCondition
{
	public GuideHasAvatarType type;
	public GuideHasAvatarConType conType;
	public float value;
}