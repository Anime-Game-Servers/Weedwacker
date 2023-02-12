using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RandomQuestElemPoolExcelConfig
{
	public uint id;
	public uint poolId;
	public uint weight;
	public QuestElemSample[] sampleList;

	public class QuestElemSample
	{
		public string type;
		public string content;
	}
}