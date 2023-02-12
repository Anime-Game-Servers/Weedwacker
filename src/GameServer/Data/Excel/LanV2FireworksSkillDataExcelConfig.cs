using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LanV2FireworksSkillDataExcelConfig
{
	public uint skillId;
	public FireworksReformSkillType skillType;
	public uint staminaValueCost;
	public uint unlockChallengeId;
	public int deltaFireElementValue;
	public uint luckyProb;
	public uint factorAddValueMin;
	public uint factorAddValueMax;
	public uint[] effectParams;
	public uint skillTitleTextMapHash;
	public uint skillDescTextMapHash;
	public uint[] descArgs;
}