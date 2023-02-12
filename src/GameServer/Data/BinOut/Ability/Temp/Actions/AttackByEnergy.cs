using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AttackByEnergy : ConfigAbilityAction
{
	public object energy;
	public float overDamageRatio;
	public float overDamageMaxHPRatio;
}
