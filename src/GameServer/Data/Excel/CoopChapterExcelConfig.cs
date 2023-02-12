using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CoopChapterExcelConfig
{
	public uint id;
	public uint avatarId;
	public uint chapterNameTextMapHash;
	public uint coopPageTitleTextMapHash;
	public uint chapterSortId;
	public uint avatarSortId;
	public string chapterIcon;
	public CoopCondConfig[] unlockCond;
	public uint[] unlockCondTips;
	public uint openMaterialId;
	public uint openMaterialNum;
	public string beginTimeStr;
	public uint confidenceValue;
	public string pointGraphPath;
	public float graphXRatio;
	public float graphYRatio;
}