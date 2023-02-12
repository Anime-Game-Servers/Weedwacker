using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CustomLevelDungeonConfig
{
	public uint dungeonID;
	public uint order;
	public string jsonPath;
	public string mapPrefabPath;
	public byte mapScenePicHashPre;
	public uint mapScenePicHashSuffix;
	public byte dataPicHashPre;
	public uint dataPicHashSuffix;
	public uint roomNum;
	public uint roomNameFormatTextMapHash;
	public string corridors;
	public uint[] countBrickList;
}