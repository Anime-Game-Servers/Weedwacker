using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public class PersonalSceneJumpPoint : ConfigScenePoint
{
	public uint tranSceneId;
	public string titleTextID;
	public Vector triggerSize;
	public float open_time;
	public float close_time;
	public bool isHomeworldDoor;
}
