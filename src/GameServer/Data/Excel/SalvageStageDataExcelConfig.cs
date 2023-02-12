using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class SalvageStageDataExcelConfig
{
	public uint stageId;
	public uint startDay;
	public uint unlockCondId;
	public uint[] landGroupLinkList;
	public uint[] seaGroupLinkList;
	public uint[] unlockChallengeGroupLinkList;
	public uint[] salvageChallengeIdList;
}