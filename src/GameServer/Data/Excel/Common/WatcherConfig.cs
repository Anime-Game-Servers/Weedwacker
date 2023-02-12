using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class WatcherConfig
{
	public uint id;
	public WatcherTriggerConfig triggerConfig;
	public uint progress;
	public bool isDisuse;
}