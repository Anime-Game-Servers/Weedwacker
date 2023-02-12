using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class OfferingLevelUpExcelConfig
{
	public uint offeringId;
	public uint level;
	public bool isMaxLevel;
	public IdCountConfig[] consumeItemConfigVec;
	public uint rewardId;
	public OfferingActionContent[] actionVec;
	public uint cutSceneId;
	public bool isAutoTakeReward;

	public class OfferingActionContent
	{
		public OfferingActionType actionType;
		public string param;
	}
}