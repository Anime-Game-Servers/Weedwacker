using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class SetPartControlTarget : ConfigAbilityAction
{
	public string[] partRootNames;
	public ControlPartTargetType targetType;
}
