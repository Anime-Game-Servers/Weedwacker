using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AddElementDurability : ConfigAbilityAction
{
	public object value;
	public string modifierName;
	public ElementType elementType;
	public SortModifierType sortModifier;
	public bool useLimitRange;
	public object maxValue;
	public object minValue;
}
