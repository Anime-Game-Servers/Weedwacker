using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BlossomRefreshExcelConfig
{
	public uint id;
	public uint nameTextMapHash;
	public string icon;
	public uint descTextMapHash;
	public uint cityId;
	public BlossomRefreshType refreshType;
	public uint refreshCount;
	public string refreshTime;
	public OpenStateType openState;
	public uint openLevel;
	public uint closeLevel;
	public BlossomRefreshCond[] refreshCondVec;
	public uint reviseLevel;
	public ItemLimitType itemLimitType;
	public uint blossom_chest_id;
	public uint camp_update_need_count;
	public uint roundMaxCount;
	public BlossomRewardExcelConfig[] dropVec;
	public BlossomShowType clientShowType;
	public bool hideBG;
	public BlossomRewardType rewardType;

	public class BlossomRefreshCond
	{
		public BlossomRefreshCondType type;
		public uint[] param;
	}
	public class BlossomRewardExcelConfig
	{
		public uint drop_id;
		public uint preview_reward;
	}
}