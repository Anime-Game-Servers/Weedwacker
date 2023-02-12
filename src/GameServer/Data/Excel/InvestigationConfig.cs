using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class InvestigationConfig
{
	public uint id;
	public uint cityId;
	public uint[] nextInvestigationIdList;
	public OpenStateType unlockOpenStateType;
	public uint unlockLevel;
	public uint rewardId;
	public uint titleTextMapHash;
	public InvestigationType investigationType;
}