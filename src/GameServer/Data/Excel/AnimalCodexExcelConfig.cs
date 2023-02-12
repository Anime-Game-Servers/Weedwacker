using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class AnimalCodexExcelConfig
{
	public uint Id;
	public AnimalCodexType type;
	public uint describeId;
	public bool isSeenActive;
	public uint SortOrder;
	public bool isDisuse;
	public bool showOnlyUnlocked;
	public AnimalCodexSubType subType;
	public AnimalCodexCountType countType;
	public uint descTextMapHash;
	public string modelPath;
	public uint pushTipsCodexId;
}