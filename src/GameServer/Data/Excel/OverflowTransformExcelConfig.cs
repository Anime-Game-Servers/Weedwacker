using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class OverflowTransformExcelConfig
{
	public OverflowTransformType transformType;
	public uint transformId;
	public uint transformBaseCount;
	public IdCountConfig[] transformResults;
	public ItemLimitType transformItemLimitType;
}