using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MechanicusCardExcelConfig
{
	public uint ID;
	public uint costPoints;
	public MechanicusCardType cardType;
	public uint effectID;
	public uint lastRound;
	public uint descTextMapHash;
	public string[] descParamList;
	public uint gear_id;
}