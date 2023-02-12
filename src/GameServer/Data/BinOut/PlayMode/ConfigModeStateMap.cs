using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigModeStateMap
{
	public Dictionary<string, ConfigActionPanelState> states;
	public Dictionary<PlayModeType, ConfigActionPanelMode> modes;

	public class ConfigActionPanelState
	{
		public Dictionary<ActionSlotType, ConfigActionButton[]> slotMap;
		public Dictionary<ActionSlotType, ConfigActionButton[]> slotMapJoypadOverride;

		public class ConfigActionButton
		{
			public ActionBtnType type;
			public bool forceShow;
			public bool onlyHandleInput;
		}
	}
	public class ConfigActionPanelMode
	{
		public Dictionary<ActionPanelState, string> stateMap;
	}
}