using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class EffigyDifficultyExcelConfig
{
	public uint id;
	public uint challengeId;
	public uint baseScore;
	public EffigyDifficulty monsterDifficulty;
	public uint monsterLevel;
	public float scoreRatio;
	public uint finishChallengeIndex;
}