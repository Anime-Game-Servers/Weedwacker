using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextActionSetAnimatorTrigger : ContextAction
{
	public ActivityBannerUIElementType uiElement;
	public string triggerName;
	public bool setOrReset;
}