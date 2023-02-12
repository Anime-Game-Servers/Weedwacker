using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioEventCulling
{
	public Dictionary<string, ConfigAudioEventCullingRuleBase[]> ruleMap;
	public ConfigAudioEventCullingRuleBase[] globalRules;
}