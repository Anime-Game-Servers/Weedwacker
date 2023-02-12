using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideOpenStateCondition : ConfigGuideCondition
{
	public GuideOpenStateType openState;
	public bool value;
}