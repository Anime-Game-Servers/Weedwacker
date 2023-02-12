using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LuminanceStoneChallengeStageExcelConfig
{
	public uint stageId;
	public uint dayIndex;
	public uint stageTitleTextMapHash;
	public uint stageDescTextMapHash;
	public uint stageLockTitleTextMapHash;
	public uint stageLockDescTextMapHash;
	public uint[] relatedCondId;
	public uint[] watcherList;
	public uint[] questList;
	public uint BundleID;
	public uint pushTipsID;
}