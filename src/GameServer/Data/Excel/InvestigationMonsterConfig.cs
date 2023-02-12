using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class InvestigationMonsterConfig
{
	public uint id;
	public uint cityId;
	public uint[] monsterIdList;
	public uint[] groupIdList;
	public uint unlockParentQuestId;
	public uint preUnlockParentQuestId;
	public uint[] unlockChapterIdList;
	public uint[] unlockWqParentQuestIdList;
	public uint wqAcceptHintTextMapHash;
	public uint activeUnlockQuestActivityId;
	public uint rewardPreviewId;
	public InvestigationMonsterMapMarkCreateType mapMarkCreateType;
	public InvestigationMonsterMapMarkCreateCondition mapMarkCreateCondition;
	public MonsterCategory monsterCategory;
	public uint nameTextMapHash;
	public string icon;
	public uint descTextMapHash;
	public uint lockDescTextMapHash;
	public uint[] occupiedQuestIdList;

	public class InvestigationMonsterMapMarkCreateCondition
	{
		public InvestigationMonsterMapMarkCreateConditionType conditionType;
		public uint conditionParam;
	}
}