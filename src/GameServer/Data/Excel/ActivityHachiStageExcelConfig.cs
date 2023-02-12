using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityHachiStageExcelConfig
{
	public uint Id;
	public uint stageId;
	public uint[] questId;
	public uint questTitleTextMapHash;
	public uint questDescTextMapHash;
	public uint stealthTitleTextMapHash;
	public uint battleDescTextMapHash;
	public uint stealthWatcher;
	public uint battleWatcher;
	public string stealthGroup;
	public string battleGroup;
	public uint stealthPushTips;
	public uint battlePushTips;
	public uint pushTip;
	public uint openDay;
	public float[] stealthTriggerPointMarkPos;
	public float[] stealthMarkPos;
	public float[] battleMarkPos;
	public uint[] finalQuestId;
	public uint[] mapMarkLoadQuest;
	public uint stealthChallengeIndex;
	public uint battleChallengeIndex;
	public uint stealthRadius;
	public uint battleRadius;
}