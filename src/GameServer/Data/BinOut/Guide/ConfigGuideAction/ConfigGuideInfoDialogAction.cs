using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideInfoDialogAction : ConfigGuideAction
{
	public string title;
	public string content;
	public ConfigGuideAction[] onOKActions;
	public ConfigGuideAction[] onCancelActions;
}