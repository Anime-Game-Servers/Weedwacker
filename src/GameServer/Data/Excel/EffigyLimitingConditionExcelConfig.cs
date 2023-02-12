using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class EffigyLimitingConditionExcelConfig
{
	public uint id;
	public uint descTextMapHash;
	public EffigyCondition conditionType;
	public string icon;
	public uint conditionParam1;
	public uint[] conditionParam2;
	public uint exclusiveId;
	public bool isInRow;
	public uint exclusiveDescTextMapHash;
	public int score;
}