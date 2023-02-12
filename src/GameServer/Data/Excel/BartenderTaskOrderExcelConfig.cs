using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BartenderTaskOrderExcelConfig
{
	public uint questId;
	public uint[] orderId;
	public uint contentParam;
	public uint dialogIdSucc;
	public uint dialogIdFail;
	public bool isGuideQuest;
	public uint nextQuestId;
}