using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class DestroyTile : ConfigAbilityAction
{
	public string tileName;
	public ConfigBaseAttackPattern attackPattern;
}
