using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class IrodoriMasterExcelConfig
{
	public uint ID;
	public uint levelID;
	public IrodoriMasterLevelType levelType;
	public uint unlockDay;
	public uint[] watcherList;
	public uint sliverChallengeID;
	public uint goldChallengeID;
	public uint goldChallengeTime;
	public uint condID;
	public uint guideCondID;
	public uint guideQuestID;
	public uint battleDescTextMapHash;
	public uint battleNameTextMapHash;
}