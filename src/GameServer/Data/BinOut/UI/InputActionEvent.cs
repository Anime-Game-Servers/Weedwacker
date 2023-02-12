using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.UI;

public class InputActionEvent
{
	public int priority;
	public InputEventType eventType;
	public ContextEventType nextToHandle;
	public ConfigBaseInputEvent eventConfig;
	public InputEventType proxyEventType;
	public ContextEventType contextEvent;
}
