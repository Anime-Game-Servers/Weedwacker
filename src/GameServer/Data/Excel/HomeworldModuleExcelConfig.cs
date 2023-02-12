using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HomeworldModuleExcelConfig
{
	public uint Id;
	public bool isFree;
	public uint unlockTipIfUnFreeTextMapHash;
	public uint worldSceneId;
	public uint defaultRoomSceneId;
	public uint[] optionalRoomSceneIdVec;
	public uint moduleNameTextMapHash;
	public uint moduleDescTextMapHash;
	public string[] region;
	public string[] regionPointPos;
	public string smallImageAddr;
	public string bigImageAddr;
}