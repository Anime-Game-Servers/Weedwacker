using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLuaHack
{
	public string UILuaScriptPath;
	public bool enableLuaPatch;
	public bool enableAllContextLuaPatch;
	public string[] UILuaPatchContextStartupList;
	public string[] UILuaPatchContextSetupViewList;
	public string[] UILuaPatchContextPostSetupViewList;
	public string[] UILuaPatchContextSetActiveEnabledList;
	public string[] UILuaPatchContextSetActiveDisabledList;
	public string[] UILuaPatchContextDestroyList;
	public string[] UILuaPatchContextDestroyForceList;
	public Dictionary<string, string[]> UILuaPatchContextButtonMap;
	public Dictionary<string, string[]> UILuaPatchContextInputFieldMap;
	public Dictionary<string, string[]> UILuaPatchContextDrowdownMap;
	public Dictionary<string, string[]> UILuaPatchContextToggleMap;
	public Dictionary<string, string[]> UILuaPatchContextSliderMap;
	public Dictionary<string, string[]> UILuaPatchContextPanelMap;
}