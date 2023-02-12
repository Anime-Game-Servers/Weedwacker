using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMarkGlobal
{
	public Dictionary<MarkIconType, ConfigMarkIcon> markIconConfig;
	public MarkIconType[] customMarkIcons;
	public Dictionary<SceneBuildingType, MarkIconType> sceneBuildingMarks;
	public Dictionary<MarkOrder, int> markOrderToLayerMap;

	public class ConfigMarkIcon
	{
		public string iconName;
		public uint materialIndex;
		public MarkType markType;
		public string effectName;
		public bool ignoreRaycastOnMap;
		public string title;
		public string desc;
		public MarkOrder markLayer;
		public MarkVisibilityType visibilityOnRadar;
		public MarkVisibilityType visibilityOnMap;
		public bool showHeightOnRadar;
		public bool showOnLockedArea;
		public MarkPluginIconType pluginIconType;
		public FallbackMarkTipsType fallbackMarkTipsType;
	}
}