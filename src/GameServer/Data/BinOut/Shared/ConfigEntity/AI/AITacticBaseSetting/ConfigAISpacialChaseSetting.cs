using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigAISpacialChaseSetting : ConfigAITacticBaseSetting
{
	public ConfigAISpacialChaseData defaultSetting;
	public Dictionary<int, ConfigAISpacialChaseData> specification;

	public class ConfigAISpacialChaseData
	{
		public int speedLevel;
		public float chaseStartDistance;
		public float chaseStopDistance;
		public float yOffsetMin;
		public float yOffsetMax;
		public float segmentDistance;
		public ConfigAIRaycastCondition[] canStartRangeByRaycast;
	}
}