using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityChessMapExcelConfig
{
	public uint chessMapID;
	public uint mapNameTextMapHash;
	public uint descTextMapHash;
	public uint unlockTipsTextMapHash;
	public string mapIconPath;
	public uint buildGearLimit;
	public uint dungeonID;
	public uint entryPointId;
	public uint unlockDay;
	public bool isTeachMap;
	public uint prevMapID;
	public bool show;
	public uint[] entrancePointIDList;
	public uint[] exitPointIDList;
}