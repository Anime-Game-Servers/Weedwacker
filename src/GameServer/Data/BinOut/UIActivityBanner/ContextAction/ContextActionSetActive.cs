using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextActionSetActive : ContextAction
{
	public ActivityBannerUIElementType uiElement;
	public bool active;
	public bool setParent;
}