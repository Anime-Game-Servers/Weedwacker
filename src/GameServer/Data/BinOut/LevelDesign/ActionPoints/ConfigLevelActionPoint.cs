using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLevelActionPoint
{
	public uint sceneId;
	public ConfigActionPoint[] actionPoints;

	public class ConfigActionPoint
	{
		public uint localId;
		public ActionPointType type;
		public Vector pos;
		public Vector rot;
		public int capacity;
		public float actZoneInnerRadius;
		public float actZoneOuterRadius;
		public int freestyle;
		public bool faceCenter;
	}
}