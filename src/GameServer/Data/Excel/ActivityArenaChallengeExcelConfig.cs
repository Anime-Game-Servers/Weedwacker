using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityArenaChallengeExcelConfig
{
	public uint ID;
	public uint scheduleId;
	public uint arenaChallengeId;
	public uint arenaChallengeLevel;
	public bool isExtraLevel;
	public uint watcherId;
	public uint challengeTargetTextMapHash;
	public uint challengeTarget1TextMapHash;
	public uint challengeTarget2TextMapHash;
	public string challengeDesc;
	public string challengeDesc1;
	public string challengeDesc2;
}