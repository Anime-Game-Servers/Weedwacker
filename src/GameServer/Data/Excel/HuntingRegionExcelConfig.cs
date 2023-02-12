using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HuntingRegionExcelConfig
{
	public uint id;
	public float[] centerPosList;
	public uint centerRadius;
	public uint[] safeClueGroup;
	public uint[] clueGroup;
	public uint[] safeDestinationGroup;
	public uint[] destinationGroup;
	public uint regionInfoTextMapHash;
	public uint[] certainFinalMonsterId;
}