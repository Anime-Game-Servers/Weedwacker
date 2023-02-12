using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LoadingSituationExcelConfig
{
	public uint stageID;
	public LoadingTipsSituationType loadingSituationType;
	public uint[] sceneID;
	public uint[] area1_ID;
	public LoadingAreaType areaTerrainType;
	public string picPath;
}