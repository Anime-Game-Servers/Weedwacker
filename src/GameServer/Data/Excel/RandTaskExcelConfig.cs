using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RandTaskExcelConfig
{
	public uint ID;
	public uint titleTextMapHash;
	public RandTaskContentType contentType;
	public uint reward;
	public bool needUI;
	public uint targetTextMapHash;
	public uint enterDistance;
	public uint exitDistance;
}