using Weedwacker.GameServer.Data.Enums;
namespace Weedwacker.GameServer.Data;

public class ConfigDialogGroup
{
	public uint talkId;
	public DialogGroupSchemeType type;
	public ConfigDialogScheme[] dialogList;

	public class ConfigDialogScheme
	{
		public uint id;
		public uint[] nextDialogs;
		public TalkShowType talkShowType;
		public TalkRoleEx talkRole;
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
		public string optionIcon;

		public class TalkRoleEx
		{
			public TalkRoleType type;
			public string id;
		}
	}
}