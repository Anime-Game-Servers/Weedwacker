using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAITarget
{
	public AITargetSystemType[] defaultTargetPrioritys;
	public Dictionary<int, AITargetSystemType[]> specificationTargetPrioritys;
}