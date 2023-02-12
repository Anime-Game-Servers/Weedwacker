using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class GivingExcelConfig
{
	public uint Id;
	public uint talkId;
	public uint mistakeTalkId;
	public BagTab tab;
	public bool isRepeatable;
	public GivingMethod givingMethod;
	public IdCountConfig[] exactItems;
	public uint exactFinishTalkId;
	public uint[] givingGroupIds;
	public uint givingGroupCount;
	public bool highlight;
	public string icon;
	public bool isRemoveItem;
	public bool isReset;
	public bool isMpEnable;
	public GivingType givingType;
	public bool isTakeBack;
}