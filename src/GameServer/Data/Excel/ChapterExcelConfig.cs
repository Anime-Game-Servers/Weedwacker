using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ChapterExcelConfig
{
	public uint id;
	public uint beginQuestId;
	public uint endQuestId;
	public uint needPlayerLevel;
	public uint activityId;
	public string needBeginTimeStr;
	public uint chapterNumTextMapHash;
	public uint chapterTitleTextMapHash;
	public string chapterIcon;
	public byte chapterImageHashPre;
	public uint chapterImageHashSuffix;
	public uint chapterImageTitleTextMapHash;
	public uint inActivityNeedPlayerLevel;
	public string chapterSerialNumberIcon;
}