using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CustomSlotConfig
{
	public uint slotID;
	public uint[] optionalPartsIdList;
	public bool isNecessary;
	public uint[] defaultPartsIdList;
	public uint[] passPartIdList;
	public uint initPartsId;
}