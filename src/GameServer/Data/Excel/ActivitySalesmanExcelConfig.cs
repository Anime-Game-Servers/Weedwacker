using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivitySalesmanExcelConfig
{
	public uint scheduleId;
	public uint[] dailyConfigIdList;
	public uint[] normalRewardIdList;
	public uint[] specialRewardIdList;
	public float[] specialProbList;
	public SalesmanSpecialReward specialReward;

	public class SalesmanSpecialReward
	{
		public SalesmanSpecialRewardType rewardType;
		public SalesmanSpecialRewardObtainMethod obtainMethod;
		public string obtainParam;
		public uint id;
		public uint previewId;
	}
}