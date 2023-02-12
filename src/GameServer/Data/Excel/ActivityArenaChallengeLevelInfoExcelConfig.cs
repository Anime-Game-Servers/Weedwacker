using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityArenaChallengeLevelInfoExcelConfig
{
	public uint ID;
	public uint scheduleId;
	public uint levelId;
	public uint levelNameTextMapHash;
	public uint monsterPreviewId;
	public string monsterConfig;
	public uint levelDescTextMapHash;
	public string levelDescParams;
	public uint monsterPreviewIdHardChallenge;
	public string monsterConfigHardChallenge;
	public uint levelHardChallengeDescTextMapHash;
	public string levelHardChallengeDescParams;
	public uint levelDetailDescTextMapHash;
	public uint[] challengeIdList;
}