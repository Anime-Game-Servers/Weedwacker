using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared;

public class ConfigStateAudioEvent
{
	public string currentStateName;
	public ConfigWwiseString audioEvent;
	public string[] otherStateNames;
	public StateAudioEventUsage usage;
}