using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ExpeditionChallengeExcelConfig
{
	public uint id;
	public uint unlockTime;
	public uint groupId;
	public uint rewardChallengeIndex;
	public uint rewardId;
	public uint challengeNameTextMapHash;
	public uint challengeDescTextMapHash;
	public string superElement;
	public float[] centerPosList;
	public uint centerRadius;
}