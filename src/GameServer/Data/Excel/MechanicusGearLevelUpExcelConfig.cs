using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MechanicusGearLevelUpExcelConfig
{
	public uint ID;
	public uint gearID;
	public uint gearLevel;
	public uint gearLevelUpMoney;
	public uint gearNameTextMapHash;
	public uint gearShortNameTextMapHash;
	public uint descTextMapHash;
	public string gearIconPath;
	public uint attack;
	public uint attackSpeed;
	public uint attackRange;
	public uint build_cost;
	public uint demolition_refund;
	public SGVConfig[] globalValueParam;
	public uint[] effectList;
}