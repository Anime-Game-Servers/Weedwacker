using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextActionSetTextWithMainQuestName : ContextAction
{
	public ActivityBannerUIElementType uiElement;
	public string textMap;
	public uint mainQuestId;
}