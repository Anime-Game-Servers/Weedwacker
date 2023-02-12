using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class GetPos : ConfigAbilityAction
{
	public string key;
	public GetPosType posType;
}
