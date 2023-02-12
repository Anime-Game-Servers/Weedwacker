using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class NewActivityWatcherConfig : WatcherConfig
{
	public uint rewardID;
	public uint rewardPreview;
	public uint activitychallengetipsTextMapHash;
	public uint extraActivitychallengetipsTextMapHash;
	public bool isAutoGrant;
}