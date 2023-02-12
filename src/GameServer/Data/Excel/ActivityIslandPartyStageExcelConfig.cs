using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityIslandPartyStageExcelConfig
{
	public uint id;
	public ActivityIslandPartyStageType stageType;
	public uint galleryId;
	public uint seriesId;
	public uint matchId;
	public uint draftId;
	public uint unlockDay;
	public uint titleTextMapHash;
	public uint descTextMapHash;
	public uint bannerDescTextMapHash;
	public uint failHintTextMapHash;
	public uint[] watcherList;
	public uint[] scoreIDList;
	public uint pushTipsID;
}