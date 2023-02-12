using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class IrodoriChessMapExcelConfig
{
	public uint mapId;
	public uint dungeonId;
	public uint entryPointId;
	public bool show;
	public uint[] cardPool;
	public uint totalCardPoints;
	public Dictionary<uint, uint> singleGearLimits;
	public uint[] entrancePointList;
	public uint[] exitPointList;
	public uint[] disorderList;
	public uint[] entryPageDisorderList;
	public uint initBuildingPoints;
	public bool isHardMap;
	public uint mapNameTextMapHash;
	public uint descTextMapHash;
	public uint difficulty;
	public string mapIconPath;
	public Dictionary<uint, uint> presetGearMap;
}