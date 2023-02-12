using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class QuestAcceptionMarkExcelConfig
{
	public uint configId;
	public uint subQuestId;
	public uint npcId;
	public bool isDailyNpc;
	public uint sceneId;
	public float[] fallbackPosition;
	public bool blockMP;
	public uint descTextMapHash;
	public uint acceptableTimeTipsTextMapHash;
}