using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DailyTaskExcelConfig
{
	public uint ID;
	public uint cityId;
	public uint poolId;
	public DailyTaskType type;
	public uint rarity;
	public uint questId;
	public uint[] oldGroupVec;
	public uint[] newGroupVec;
	public DailyTaskFinishType finishType;
	public uint finishParam1;
	public uint finishParam2;
	public uint finishProgress;
	public uint taskRewardId;
	public string centerPosition;
	public uint enterDistance;
	public uint exitDistance;
	public uint titleTextMapHash;
	public uint descriptionTextMapHash;
	public uint targetTextMapHash;
	public float radarRadius;
}