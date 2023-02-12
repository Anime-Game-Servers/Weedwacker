using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class H5ActivityExcelConfig
{
	public uint h5ActivityId;
	public uint nameTextMapHash;
	public uint detailTextMapHash;
	public uint rewardPreview;
	public LogicType condComb;
	public H5ActivityCondConfig[] condList;
}