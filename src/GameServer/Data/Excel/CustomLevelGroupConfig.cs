using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CustomLevelGroupConfig
{
	public uint groupId;
	public uint[] dungeonList;
	public uint[] activityDungeonList;
	public uint maxEditCount;
	public uint storeMaxCount;
	public uint coinChallengeId;
	public uint coinExhibitionId;
	public uint finishExhibitionId;
	public uint costAlert;
}