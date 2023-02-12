using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FleurFairMiniGameExcelConfig
{
	public uint id;
	public FleurFairMiniGameType miniGameType;
	public uint descTextMapHash;
	public uint galleryId;
	public uint configId;
	public uint openDay;
	public uint questId;
	public uint rewardRankLowTextMapHash;
	public uint rewardRankMiddleTextMapHash;
	public uint rewardRankHighTextMapHash;
	public uint[] watcherIdList;
	public uint[] avatarIdList;
	public uint[] avatarScore;
	public uint[] tipsIdList;
	public uint tipsDescTextMapHash;
	public float[] pos;
}