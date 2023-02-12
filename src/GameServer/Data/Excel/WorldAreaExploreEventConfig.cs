using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class WorldAreaExploreEventConfig
{
	public uint EventID;
	public uint SceneID;
	public uint AreaID;
	public ExploreEventType EventType;
	public string[] Param;
	public uint ExploreWeight;
	public uint rewardID;
}