using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BlessingScanTypeExcelConfig
{
	public uint id;
	public uint typeId;
	public uint priority;
	public uint[] upPoolId;
	public uint dailyScanLimit;
	public uint typeNameTextMapHash;
	public uint typeNameWithColorTextMapHash;
}