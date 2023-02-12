using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MpPlayGroupExcelConfig
{
	public uint EntryId;
	public uint playId;
	public uint[] serverLuaCallGroupList;
	public uint resinCost;
	public uint materialCostId;
	public uint materialCostNum;
	public bool isDirectToBag;
	public uint[] upAvatarList;
	public MpPlayShowType clientShowType;
	public MpCrucibleRewardConfig[] rewardVec;
	public uint[] activateGroupList;
	public uint[] groupList;
	public uint bornGroupId;
	public uint bornConfigId;
	public uint safeGroupId;
	public uint safeConfigId;
	public uint rebornGroupId;
	public uint rebornConfigId;
	public uint rewardGroupId;
	public uint rewardConfigId;
	public uint generalRewardConfigId;
	public uint prepareTime;
	public uint singlePrepareTime;
	public float[] centerPosList;
	public uint centerRadius;
	public float[] targetPosList;
	public uint reviseId;
	public uint[] rateList;
	public string limitRegion;
	public uint[] abilityGroupList;
	public bool isDisabled;

	public class MpCrucibleRewardConfig
	{
		public uint dropID;
		public uint rewardId;
		public uint rewardPreview;
	}
}