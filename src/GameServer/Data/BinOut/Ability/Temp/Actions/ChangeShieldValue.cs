using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ChangeShieldValue : ConfigAbilityAction
{
	public object shieldHPRatio;
	public object shieldHP;
	public object maxShieldByHPRatio;
	public object maxShieldHP;
	public string modifierName;
	public bool refreshTime;
}
