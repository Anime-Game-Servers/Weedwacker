using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideHasItemCondition : ConfigGuideCondition
{
	public uint[][] itemIDLists;
	public int[] materialTypeList;
	public GuideItemType type;
	public bool notHave;
	public float value;
}