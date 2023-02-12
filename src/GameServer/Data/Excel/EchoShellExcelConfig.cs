using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class EchoShellExcelConfig
{
	public uint id;
	public EchoShellType echoShellType;
	public uint storyId;
	public uint voiceTitleTextMapHash;
	public uint voiceDescTextMapHash;
	public uint[] voiceList;
	public uint[] reminderList;
	public string imagePath;
	public uint markID;
	public float[] markPosition;
	public uint markTipTitleTextMapHash;
	public uint markTipContentTextMapHash;
	public uint[] exclusiveSceneTags;
	public uint relatedDungeonID;
	public uint dungeonPassedLockTipTextMapHash;
	public uint relatedDungeonEntryID;
	public uint orderID;
	public uint[] relatedDungeonEntryIDList;
	public uint relatedSubQuestID;
}