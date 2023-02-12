using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigKeyboardLayout
{
	public Dictionary<KeyboardType, ConfigKeyboardLayoutItem> configKeyboardLayouts;
	public Dictionary<InputActionGroupType, InputActionType[]> inputActionTypeGroups;

	public class ConfigKeyboardLayoutItem
	{
		public Dictionary<ConfigKeyCode, string> keyCodeFriendlyName;
	}
}