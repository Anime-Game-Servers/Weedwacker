using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class IrodoriPoetryExcelConfig
{
	public uint ID;
	public uint condID;
	public uint themeCondID;
	public uint unlockDay;
	public IrodoriPoetryEntityType entityType;
	public IrodoriPoetryScanConfig[] scanConfigList;
	public uint mainQuestID;
	public uint minInspirationQuestID;
	public uint fillPoetryQuestID;
	public uint[] reminderIDList;
	public uint watcherID;
	public uint cameraHintTextMapHash;
	public uint themeTitleTextMapHash;
	public uint themeDescTextMapHash;
	public uint poetryTitleTextMapHash;
	public uint[] existsLineIDList;

	public class IrodoriPoetryScanConfig
	{
		public uint[] indexIdList;
		public uint lineId;
	}
}