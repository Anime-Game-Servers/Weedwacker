using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigBattleFervorUpdateTrigger_ByStateIDChanged : ConfigBattleFervorUpdateTrigger
{
	public BattleFervorStateIDTriggerType type;
	public string[] stateIDs;
	public float cd;
}