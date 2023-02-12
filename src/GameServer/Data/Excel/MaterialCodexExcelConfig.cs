using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MaterialCodexExcelConfig
{
	public uint Id;
	public MaterialCodexType type;
	public uint materialId;
	public uint SortOrder;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public string icon;
	public bool isDisuse;
	public bool showOnlyUnlocked;
}