using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCodexQuest
{
	public uint mainQuestId;
	public QuestType questType;
	public ConfigCodexQuestText mainQuestTitle;
	public ConfigCodexQuestText mainQuestDesp;
	public ConfigCodexQuestText chapterTitle;
	public ConfigCodexQuestText chapterNum;
	public ConfigCodexQuestSubQuest[] subQuests;

	public class ConfigCodexQuestText
	{
		public uint textId;
		public CodexQuestTextType textType;
	}
	public class ConfigCodexQuestSubQuest
	{
		public ConfigCodexQuestText subQuestTitle;
		public ConfigCodexQuestItem[] items;

		public class ConfigCodexQuestItem
		{
			public uint itemId;
			public CodexQuestItemType itemType;
			public uint nextItemId;
			public ConfigCodexQuestText speakerText;
			public ConfigCodexQuestText speakerText2;
			public ConfigCodexQuestText[] texts;
			public ConfigCodexQuestDialogSingle[] dialogs;
			public ConfigCodexQuestDialogSingle[] dialogs2;

			public class ConfigCodexQuestDialogSingle
			{
				public ConfigCodexQuestText text;
				public uint soundId;
				public uint nextItemId;
			}
		}
	}
}