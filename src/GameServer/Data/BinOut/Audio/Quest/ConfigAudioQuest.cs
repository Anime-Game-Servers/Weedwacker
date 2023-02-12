using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioQuest
{
	public ConfigAudioQuestOps[] quests;

	public class ConfigAudioQuestOps
	{
		public uint questId;
		public ConfigWwiseString[] eventsOnStart;
		public AudioStateOp[] statesOnStart;
		public ConfigWwiseString[] eventsOnFinish;
		public AudioStateOp[] statesOnFinish;
	}
}