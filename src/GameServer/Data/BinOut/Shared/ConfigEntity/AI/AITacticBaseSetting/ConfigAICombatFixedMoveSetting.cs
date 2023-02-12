using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAICombatFixedMoveSetting : ConfigAITacticBaseSetting
{
	public ConfigAICombatFixedMoveData defaultSetting;
	public Dictionary<int, ConfigAICombatFixedMoveData> specification;

	public class ConfigAICombatFixedMoveData
	{
		public ActionPointType pointType;
		public float cdActionPoint;
		public int speedLevel;
		public float turnSpeedOverride;
		public float detectDistance;
		public float overtime;
		public uint skillID;
	}
}