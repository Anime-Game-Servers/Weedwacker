using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CityConfig
{
	public uint cityId;
	public uint sceneId;
	public uint[] areaIdVec;
	public uint cityNameTextMapHash;
	public int mapPosX;
	public int mapPosY;
	public float zoomForExploration;
	public uint adventurePointId;
	public string ExpeditionMap;
	public string ExpeditionWaterMark;
	public OpenStateType openState;
	public uint cityGoddnessNameTextMapHash;
	public uint cityGoddnessDescTextMapHash;
}