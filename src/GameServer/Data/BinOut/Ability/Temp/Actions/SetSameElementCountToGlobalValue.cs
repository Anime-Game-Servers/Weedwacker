using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

internal class SetSameElementCountToGlobalValue : ConfigAbilityAction
{
	public bool checkSameElement;
	public AbilityTargetting elementBaseOn;
	public string globalValueKey;
	public AbilityTargetting teamBaseOn;
}
