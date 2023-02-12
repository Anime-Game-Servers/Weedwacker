using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RandomQuestEntranceExcelConfig
{
	public uint id;
	public uint weight;
	public uint templateId;
	public LogicType filterLogicType;
	public RandomQuestFilterConfig[] filterList;

	public class RandomQuestFilterConfig
	{
		public RandomQuestFilterType filterType;
		public string filterFactor;
		public uint[] filterParamList;
	}
}