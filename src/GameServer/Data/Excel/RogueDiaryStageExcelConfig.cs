using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RogueDiaryStageExcelConfig
{
	public uint id;
	public uint condId;
	public uint[] normalDungeonIdList;
	public uint[] hardDungeonIdList;
	public uint[] insaneDungeonIdList;
	public uint optionalCardCount;
	public uint chosenCardCount;
	public RogueDiaryTiredType tiredType;
	public uint tiredReserveAvatarCount;
	public uint tiredRoundCount;
	public uint[] trialAvatarList;
	public uint[] timeLevelList;
	public uint[] watcherIdList;
	public uint pushTipsId;
	public uint dungeonNameTextMapHash;
	public uint dungeonDescTextMapHash;
}