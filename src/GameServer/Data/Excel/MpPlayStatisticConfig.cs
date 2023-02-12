using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MpPlayStatisticConfig
{
	public uint id;
	public uint MpPlayId;
	public MpPlayerSettleType settleType;
	public string[] settleParam;
	public MpPlayerSettleSyncType clientSyncType;
	public string clientSyncParam;
	public uint mpchallengetitleTextMapHash;
	public uint mpchallengeTextMapHash;
	public uint mpchallengestyleTextMapHash;
	public string image;
	public uint priority;
}