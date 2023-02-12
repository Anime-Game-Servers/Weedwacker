using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class GetHPHealedToGlobalValue : ConfigAbilityAction
{
	public GlobalValueChangeType type;
	public string key;
}