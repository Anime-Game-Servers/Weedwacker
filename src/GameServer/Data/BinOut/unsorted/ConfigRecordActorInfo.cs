using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigRecordActorInfo
{
	public string name;
	public ulong prefabHash;
	public uint serialID;
	public RecordActorType actorType;
	public uint configID;
}