using Weedwacker.GameServer.Data.BinOut.UI;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigUI
{
	public Dictionary<InputEventType, ConfigBaseInputEvent> inputEvents;
	public Dictionary<string, InputActionEvent[]> actionGroups;
	public Dictionary<string, ConfigBaseContext> context;
}