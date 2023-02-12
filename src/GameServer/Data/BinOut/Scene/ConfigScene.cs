using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Scene;

public class ConfigScene
{
	public float transRadius;
	public Dictionary<string, ConfigScenePoint> points;
	public Dictionary<string, ConfigSceneArea> areas;
	public Dictionary<string, ConfigForceField> forces;
	public Dictionary<string, ConfigLocalEntity> entities;
	public Dictionary<string, ConfigLoadingDoor> doors;

	public class ConfigSceneArea
	{
		public SceneAreaType type;
		public bool unlocked;
	}
}