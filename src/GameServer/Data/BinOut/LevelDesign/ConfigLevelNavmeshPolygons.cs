using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data;

public class ConfigLevelNavmeshPolygons
{
	public uint sceneId;
	public ConfigLevelNavmeshPolygon[] polygons;

	public class ConfigLevelNavmeshPolygon
	{
		public uint polygonId;
		public Vector[] polygon;
		public float polygonMinY;
		public float polygonMaxY;
		public uint[] allSceneTagIDs;
		public uint[] sceneTagsHashList;
	}
}