using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class HomeWorldNPCExcelConfig
{
	public uint furnitureID;
	public uint avatarID;
	public uint npcID;
	public uint[] talkIDs;
	public bool isNPC;
	public string headIcon;
	public string frontIcon;
	public string sideIcon;
	public QualityType quality;
	public uint showNameTextMapHash;
	public uint descTextMapHash;
}