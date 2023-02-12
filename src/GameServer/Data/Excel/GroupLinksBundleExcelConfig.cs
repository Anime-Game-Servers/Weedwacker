using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class GroupLinksBundleExcelConfig
{
	public uint Id;
	public ActivityGroupLinkType linkType;
	public uint[] groupList;
	public uint hintGroup;
	public uint hintRadius;
	public ActivityGroupLinkRewardType rewardType;
	public uint rewardId;
	public uint reviseLevel;
	public string icon;
	public uint nameTextMapHash;
	public uint tipsTextMapHash;
	public ActivityGroupLinkPlayType playType;
	public bool autoTracingAfterActive;
	public uint uiRadius;
	public uint trackId;
	public bool guestShow;
	public bool isDefaultShowMark;
}