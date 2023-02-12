using Weedwacker.GameServer.Data.BinOut.UI;

namespace Weedwacker.GameServer.Data;

public class ConfigBaseContext
{
	public Dictionary<string, InputActionEvent[]> actionGroups;
	public Dictionary<int, DeviceAction> stateActions;
	public bool enableInputPenetrate;
	public bool enableJoypadVirtualCursor;

	public class DeviceAction
	{
		public string keyboardTouch;
		public string keyboardMouse;
		public string joypad;
	}
}