using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FishSkillExcelConfig
{
	public uint id;
	public FishSkillCategory skillCategory;
	public FishSkillType skillType;
	public float[] param;
	public uint strength;
	public float forceFactor;
	public float[] bonusWidth;
	public float[] bonusDuration;
	public uint[] bonusOffset;
	public float[] bonusSpeed;
	public float duration;
	public uint priority;
}