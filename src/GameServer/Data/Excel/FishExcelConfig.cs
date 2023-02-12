using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FishExcelConfig
{
	public uint id;
	public uint monsterId;
	public uint itemId;
	public uint hp;
	public uint[] skillId;
	public uint bonusWidth;
	public float[] bonusDuration;
	public uint[] bonusOffset;
	public float[] bonusSpeed;
	public float[] feelerTimes;
	public float attractRange;
	public float fleeRange;
	public uint rewardId;
	public uint[] dropIdList;
	public uint fishCateId;
	public uint biteTimeout;
	public uint initPose;
	public uint compoundId;
}