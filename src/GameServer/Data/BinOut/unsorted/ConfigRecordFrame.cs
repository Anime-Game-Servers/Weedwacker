using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigRecordFrame
{
	public float deltaTime;
	public uint frameCount;
	public ConfigRecordActorBase[] actors;
}