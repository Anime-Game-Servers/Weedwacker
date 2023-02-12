using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ButtonHoldChargeMixin : ConfigAbilityMixin
{
	public uint skillID;
	public float chargeTime;
	public object secondChargeTime;
	public ConfigAbilityAction[] OnBeginUncharged;
	public ConfigAbilityAction[] OnReleaseUncharged;
	public ConfigAbilityAction[] OnBeginCharged;
	public ConfigAbilityAction[] OnReleaseCharged;
	public ConfigAbilityAction[] OnBeginSecondCharged;
	public ConfigAbilityAction[] OnReleaseSecondCharged;
	public ConfigAbilityAction[] OnCancelCharged;
	public string[] chargeStateIDs;
}
