using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BonusActivityClientExcelConfig
{
	public uint id;
	public BonusActivityType bonusActivityType;
	public uint avatarConfigId;
	public uint[] voiceIndexList;
	public uint questId;
	public uint openPlayerLevel;
	public string perfabPath;
	public uint unlockTipsTextMapHash;
}