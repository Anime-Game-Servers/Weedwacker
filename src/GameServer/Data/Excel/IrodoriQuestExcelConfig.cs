using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class IrodoriQuestExcelConfig
{
	public uint Id;
	public uint questId;
	public uint[] mainQuestIds;
	public LunaRiteQuestType questType;
	public uint openDay;
	public uint chapterTextMapHash;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public uint preQuestId;
	public uint[] preOtherQuestIds;
}