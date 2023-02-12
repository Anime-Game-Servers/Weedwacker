using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityBannerExcelConfig
{
	public uint activityId;
	public ActivityBannerType bannerType;
	public uint rewardPreviewId;
	public string jsonConfigName;
	public string prefabPath;
	public bool showDesc;
	public uint descTextMapHash;
}