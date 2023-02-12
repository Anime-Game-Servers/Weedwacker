using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class WorldAreaConfig
{
	public uint ID;
	public uint SceneID;
	public WorldAreaType AreaType;
	public uint AreaID_1;
	public uint AreaID_2;
	public bool AreaDefaultLock;
	public uint AreaNameTextMapHash;
	public uint tower_point_id;
	public ElementType elementType;
	public AreaTerrainType terrainType;
	public bool showTips;
	public float minimapScale;
}