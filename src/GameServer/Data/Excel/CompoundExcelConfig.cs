using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CompoundExcelConfig
{
	public uint id;
	public uint groupID;
	public uint nameTextMapHash;
	public uint rankLevel;
	public CompoundType type;
	public bool isDefaultUnlocked;
	public uint costTime;
	public uint queueSize;
	public IdCountConfig[] inputVec;
	public IdCountConfig[] outputVec;
	public string icon;
	public uint descTextMapHash;
	public uint countDescTextMapHash;
}