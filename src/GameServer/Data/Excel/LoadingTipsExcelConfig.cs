using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class LoadingTipsExcelConfig
{
	public uint id;
	public uint tipsTitleTextMapHash;
	public uint tipsDescTextMapHash;
	public string stageID;
	public string startTime;
	public string endTime;
	public uint minLevel;
	public uint maxLevel;
	public string limitOpenState;
	public string preMainQuestIds;
	public uint[] preQuestIdList;
	public uint[] disableQuestIdList;
	public uint[] enableDungeonId;
	public uint weight;
}