using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAbilityNode
{
	public string config;
	public uint orderId;
	public uint relatedOrderId;
	public string colorTag;
	public string[] tags;
	public string name;
	public ConfigAbilityData[] data;
	public ConfigAbilityNode[] children;
}