using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AddGlobalValueToTarget : ConfigAbilityAction
{
	public AbilityTargetting srcTarget;
	public AbilityTargetting dstTarget;
	public string srcKey;
	public string dstKey;
}
