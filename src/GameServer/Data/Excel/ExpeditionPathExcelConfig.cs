using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ExpeditionPathExcelConfig
{
	public uint id;
	public uint difficultyId;
	public string superElement;
	public uint basicRewardId;
	public uint bonusRewardId;
	public uint pathNameTextMapHash;
	public uint pathDescTextMapHash;
	public uint[] levelRewardList;
	public uint rewardPreviewId;
}