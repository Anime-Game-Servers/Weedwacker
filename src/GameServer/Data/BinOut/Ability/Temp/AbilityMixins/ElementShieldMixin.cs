using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ElementShieldMixin : ConfigAbilityMixin
{
	public ElementType elementType;
	public string showDamageText;
	public object shieldAngle;
	public object shieldHPRatio;
	public object shieldHP;
	public object damageRatio;
	public ConfigAbilityAction[] onShieldBroken;
	public ConfigAbilityAction[] onShieldSuccess;
	public ConfigAbilityAction[] onShieldFailed;
	public bool useMutiPlayerFixData;
	public bool updateShieldByMaxHp;
}
