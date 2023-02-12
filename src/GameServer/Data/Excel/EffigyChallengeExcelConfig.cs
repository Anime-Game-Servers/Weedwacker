using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class EffigyChallengeExcelConfig
{
	public uint id;
	public uint dayIndex;
	public uint dungeonId;
	public string prefab;
	public uint titleTextMapHash;
	public uint contentTextMapHash;
	public uint[] limitingConditionVec;
	public uint[] upAvatarVec;
	public uint firstPassRewardId;
}