using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAICombatSetting
{
	public Dictionary<ConfigAICombatPhase, int[]> combatPhases;
	public ConfigAICombatRole combatRole;
	public bool broadcastFearOnDeath;
}