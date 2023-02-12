using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideSetOpenStateAction : ConfigGuideAction
{
	public GuideOpenStateType openState;
	public bool value;
}