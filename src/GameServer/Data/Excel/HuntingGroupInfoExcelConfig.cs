using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HuntingGroupInfoExcelConfig
{
	public uint groupId;
	public uint regionId;
	public HuntingCluePointType pointType;
	public uint[] refIndex;
	public HuntingMonsterCreatePosType posType;
}