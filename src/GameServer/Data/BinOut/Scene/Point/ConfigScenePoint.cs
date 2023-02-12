using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point;

public abstract class ConfigScenePoint
{
	public ScenePointType type;
	public uint gadgetId;
	public ushort areaId;
	public Vector pos;
	public Vector rot;
	public Vector tranPos;
	public Vector tranRot;
	public bool unlocked;
	public string alias;
	public bool groupLimit;
	public bool isModelHidden;
}
