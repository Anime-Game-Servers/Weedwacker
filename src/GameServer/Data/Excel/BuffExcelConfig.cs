using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BuffExcelConfig : BaseServerBuffConfig
{
	public uint groupId;
	public string name;
	public string desc;
	public float time;
	public BuffStackType stackType;
	public bool isPersistent;
	public bool isDelWhenLeaveScene;
}