using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class IrodoriFlowerThemeExcelConfig
{
	public uint themeId;
	public uint gadgetId;
	public uint unlockDay;
	public uint themeTitleTextMapHash;
	public uint themeDescTextMapHash;
	public uint themeTargetTextMapHash;
	public byte targetPictureHashPre;
	public uint targetPictureHashSuffix;
	public float timeLimit;
	public uint[] flowerId;
	public uint stageUnlockCondId;
	public uint themeUnlockCondId;
	public uint watcherId;
	public uint questId;
}