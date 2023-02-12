using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioStageEvents
{
	public int id;
	public string[] stageCreateEvents;
	public ConfigAudioStageProgressEvent[] stageProgressEvents;
	public string[] stageStartEvents;
	public string[] stageMatureEvents;
	public ConfigAudioStageProgressEvent[] stageTeleportEvents;
	public string[] stageExitEvents;
	public string stateValue;
	public ConfigAudioStateGroup[] stageCreateStateGroups;
	public ConfigAudioStateGroup[] stageStartStateGroups;
	public ConfigAudioStateGroup[] stageMatureStateGroups;
	public ConfigAudioStateGroup[] stageExitStateGroups;

	public class ConfigAudioStageProgressEvent
	{
		public float progress;
		public string[] events;
	}
	public class ConfigAudioStateGroup
	{
		public ConfigWwiseString stateGroupKey;
		public ConfigWwiseString stateValue;
	}
}