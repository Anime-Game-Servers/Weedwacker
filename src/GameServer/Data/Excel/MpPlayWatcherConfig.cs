using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MpPlayWatcherConfig : WatcherConfig
{
	public uint MpPlayId;
	public uint priority;
	public bool isStore;
	public uint challengeDescTextMapHash;
	public uint challengeTitleTextMapHash;
}