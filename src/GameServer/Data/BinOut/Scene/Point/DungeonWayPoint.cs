using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public class DungeonWayPoint : ConfigScenePoint
{
	public Vector size;
	public bool isBoss;
	public bool isActive;
	public uint[] groupIds;
}
