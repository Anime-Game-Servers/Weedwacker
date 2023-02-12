using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public class SceneBuildingPoint : ConfigScenePoint
{
	public SceneBuildingType buildingType;
	public ushort fogId;
	public bool showOnLockedArea;
}
