using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LunaRiteQuestExcelConfig
{
	public uint Id;
	public uint questId;
	public LunaRiteQuestType questType;
	public uint openDay;
	public uint preQuestId;
	public uint atmosphereNeed;
	public string chapterIcon;
	public uint chapterTextMapHash;
	public uint nameTextMapHash;
	public uint descTextMapHash;
}