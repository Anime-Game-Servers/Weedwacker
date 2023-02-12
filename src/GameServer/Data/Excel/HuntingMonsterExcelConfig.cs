using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HuntingMonsterExcelConfig
{
	public uint configId;
	public uint monsterId;
	public uint associatedMonsterGroupId;
	public HuntingMonsterFinishType huntingFinishType;
	public uint[] affix;
	public string abilityGroup;
	public HuntingMonsterCreatePosType createPosType;
	public uint level;
	public uint reviseLevelId;
	public uint[] cityList;
	public HuntingOfferDifficultyType difficulty;
	public uint limitTime;
	public uint searchPointNum;
	public HuntingRefreshCond[] refreshCond;
	public uint initialPose;
	public uint[] clueTextIdList;
	public uint newsTextTextMapHash;
	public uint traitTextTextMapHash;
	public uint mechanismTitle1TextMapHash;
	public uint mechanismDesc1TextMapHash;
	public uint mechanismTitle2TextMapHash;
	public uint mechanismDesc2TextMapHash;
	public uint[] suiteId;
	public bool isDisableWandering;
	public uint routeId;

	public class HuntingRefreshCond
	{
		public HuntingRefreshCondType condType;
		public uint[] param;
	}
}