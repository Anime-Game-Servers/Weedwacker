using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAIReactActionPointSetting : ConfigAITacticBaseSetting
{
	public ConfigAIReactActionPointData defaultSetting;
	public Dictionary<int, ConfigAIReactActionPointData> specification;

	public class ConfigAIReactActionPointData
	{
		public ConfigAIPickActionPointCriteria[] reactList;

		public class ConfigAIPickActionPointCriteria
		{
			public ActionPointType pointType;
			public float detectDistance;
			public int speedLevel;
			public int[] pose;
			public NeuronName[] nerveTrigger;
			public int skillID;
		}
	}
}