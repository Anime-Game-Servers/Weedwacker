using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RogueStageExcelConfig
{
	public uint stageId;
	public uint firstPassRewardId;
	public uint previewRewardId;
	public uint openTime;
	public uint maxCoin;
	public uint maxLevel;
	public uint reviseLevelId;
	public uint stageNameTextMapHash;
	public uint stageDescTextMapHash;
	public uint[] bossIdList;
	public uint[][] monsterIdList;
	public uint[][] levelBossIdList;
	public uint preQuestId;
	public uint gotoQuestId;
	public uint[] unlockRuneList;
	public bool isStoryStage;
}