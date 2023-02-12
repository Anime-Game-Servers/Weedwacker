using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class PhotographTask
{
	public uint task_id;
	public PhotographTaskType taskType;
	public uint sceneID;
	public float centerX;
	public float centerY;
	public float centerZ;
	public float radius;
	public string[] targetGadgetID;
	public float startTime;
	public float endTime;
	public uint questid;
	public uint finishTipsTextMapHash;
	public uint startTipsTextMapHash;
}