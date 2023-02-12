using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class SECTR_Sector
{
	public SECTR_LayerGroup[] layerGroups;
	public uint sectorNameHash;
	public SECTR_SectorType type;
	public int widthIndex;
	public int heightIndex;
	public float distanceToChange;
	public Vector centerPos;
}