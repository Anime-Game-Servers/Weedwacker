using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DialogExcelConfig
{
	public uint nextDialog;
	public uint id;
	public uint[] nextDialogs;
	public TalkShowType talkShowType;
	public TalkRole talkRole;
	public uint talkContentTextMapHash;
	public uint talkTitleTextMapHash;
	public uint talkRoleNameTextMapHash;
	public string talkAssetPath;
	public string talkAssetPath_Alter;
	public string talkAudioName;
	public string actionBefore;
	public string actionWhile;
	public string actionAfter;
	public float showDuration;
	public uint groupId;
	public string optionIcon;

	public class TalkRole
	{
		public TalkRoleType type;
		public string id;
	}
}