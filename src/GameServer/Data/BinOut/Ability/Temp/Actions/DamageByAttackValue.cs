using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class DamageByAttackValue : ConfigAbilityAction
{
	public DamageAttacker attacker;
	public ConfigBornType born;
	public ConfigAttackInfo attackInfo;
}