using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FishStockExcelConfig
{
	public uint id;
	public FishStockType type;
	public Dictionary<uint, uint> fishWeight;
}