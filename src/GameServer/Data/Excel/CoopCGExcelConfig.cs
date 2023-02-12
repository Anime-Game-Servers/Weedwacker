using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CoopCGExcelConfig
{
	public uint id;
	public uint chapterId;
	public uint unlockPointId;
	public CoopCGType cgType;
	public CoopCondConfig[] unlockCond;
	public byte showImageHashPre;
	public uint showImageHashSuffix;
	public byte showImageSmallHashPre;
	public uint showImageSmallHashSuffix;
	public uint cgNameTextMapHash;
	public uint cgDesTextMapHash;
	public uint sortId;
}