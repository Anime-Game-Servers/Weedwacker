
namespace Weedwacker.GameServer.Data;

public class ConfigAIScriptedMoveToSetting : ConfigAITacticBaseSetting
{
	public ConfigAIScriptedMoveToData defaultSetting;
	public Dictionary<int, ConfigAIScriptedMoveToData> specification;

	public class ConfigAIScriptedMoveToData
	{
		public int speedLevel;
		public bool is3D;
		public bool stopByObstacle;
	}
}