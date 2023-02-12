using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MoonfinTrialLevelExcelConfig
{
	public uint levelId;
	public MoonfinTrialActivityLevelType levelType;
	public uint specificFishId;
	public uint galleryId;
	public uint challengeId;
	public uint openDay;
	public uint[] watcherID;
	public uint leadingLevel;
	public uint leadingMainQuest;
	public uint mainQuest;
	public float[] markPosition;
	public uint rewardPreviewId;
	public uint levelNameTextMapHash;
	public uint descriptionTextMapHash;
	public uint titleTextMapHash;
}