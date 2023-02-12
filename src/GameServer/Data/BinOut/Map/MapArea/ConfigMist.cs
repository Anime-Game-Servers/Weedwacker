using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigMist
{
	public uint id;
	public uint[] hideScenePointList;
	public uint sortID;
	public string prefabPath;
	public Point2D[] mapPosList;
	public bool needAnim;
	public bool showUnlockScenePoint;
}