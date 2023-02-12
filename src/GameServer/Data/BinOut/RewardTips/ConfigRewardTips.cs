using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigRewardTips
{
	public string title;
	public uint type;
	public MarkType markType;
	public MarkIconType[] markIconTypeList;
	public bool useTransPoints;
	public bool nearCity;
	public bool showRewardMapTag;
	public bool showHighLight;
}