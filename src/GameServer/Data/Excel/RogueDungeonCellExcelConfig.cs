using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RogueDungeonCellExcelConfig
{
	public uint id;
	public uint dungeonId;
	public uint cellId;
	public float[] cellCenterPos;
	public uint[] mapCoordinate;
	public uint[] adjacencyCellList;
	public uint groupId;
	public uint weightId;
	public float operatorDeltaY;
	public float doorOffset;
	public RogueCellType specialType;
	public float doorDeltaY;
	public bool isInitCell;
}