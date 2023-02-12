using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigRecord
{
	public string name;
	public string cameraAttachPoint;
	public string[] deactiveNodeList;
	public ConfigRecordActorInfo[] actorInfoList;
	public ConfigRecordFrame[] frameList;
	public uint targetFrameRate;
}