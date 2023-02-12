using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MechanicusCardEffectExcelConfig
{
	public uint ID;
	public MechanicusCardTargetType targetType;
	public uint[] targetParamList;
	public MechanicusCardEffectType effectType;
	public string effectStrParam;
	public int effectParam1;
	public int effectParam2;
	public int effectParam3;
}