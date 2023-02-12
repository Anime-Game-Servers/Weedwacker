using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigBattleFervorUpdateTrigger_ByAttackTag : ConfigBattleFervorUpdateTrigger
{
	public string[] attackTags;
	public float cd;
}