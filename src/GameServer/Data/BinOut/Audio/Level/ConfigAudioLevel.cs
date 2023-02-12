using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioLevel
{
	public ConfigWwiseString[] teleportEvents;
	public ConfigWwiseString stateGroup;
	public Dictionary<string, ConfigWwiseString> dungeonEventMap;
}