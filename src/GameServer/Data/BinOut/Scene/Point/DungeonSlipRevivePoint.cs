using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public class DungeonSlipRevivePoint : ConfigScenePoint
{
	public Vector size;
	public bool isActive;
	public uint[] groupIds;
}
